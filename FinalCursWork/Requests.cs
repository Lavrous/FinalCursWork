using System;
using System.Net;

namespace FinalCursWork
{

    public static class EnumExtensions
    {
        public static string ToLocalizedString(this Enum value)
        {
            return value switch
            {
                Requests.District.Central => "Центральный",
                Requests.District.North => "Северный",
                Requests.District.South => "Южный",
                Requests.District.East => "Восточный",
                Requests.District.West => "Западный",
                Requests.District.Suburbs => "Пригород",
                Requests.HouseType.PrivateHouse => "Частный дом",
                Requests.HouseType.OneRoomApartment => "Однокомнатная квартира",
                Requests.HouseType.TwoRoomApartment => "Двухкомнатная квартира",
                Requests.HouseType.ThreeRoomApartment => "Трехкомнатная квартира",
                Requests.HouseType.FourPlusApartment => "Четыре и более комнат",
                Requests.BuildingMaterial.Brick => "Кирпич",
                Requests.BuildingMaterial.Panel => "Панель",
                Requests.BuildingMaterial.Wood => "Дерево",
                Requests.OwnType.Ownership => "Cобственничество",
                Requests.OwnType.Rent => "Аренда",
                _ => value.ToString() // Значение по умолчанию
            };
        }
    }

    public abstract class Requests
    {
        // Перечисления для районов, типов домов и материалов
        public enum District { Central, North, South, East, West, Suburbs }
        public enum HouseType { PrivateHouse, OneRoomApartment, TwoRoomApartment, ThreeRoomApartment, FourPlusApartment }
        public enum BuildingMaterial { Brick, Panel, Wood }
        public enum OwnType { Ownership, Rent }

        // Диапазон значений
        public class Range<T> where T : struct, IComparable<T>
        {
            public T? Min { get; set; }
            public T? Max { get; set; }

            public Range(T? min, T? max)
            {
                if (min.HasValue && max.HasValue && min.Value.CompareTo(max.Value) > 0)
                {
                    throw new ArgumentException("Минимальное значение не может быть больше максимального.");
                }
                Min = min;
                Max = max;
            }

            public bool Contains(T value)
            {
                if (Min.HasValue && value.CompareTo(Min.Value) < 0) return false;
                if (Max.HasValue && value.CompareTo(Max.Value) > 0) return false;
                return true;
            }

            public override string ToString()
            {
                string minValue = Min?.ToString() ?? "Не указано";
                string maxValue = Max?.ToString() ?? "Не указано";
                return $"{minValue} - {maxValue}";
            }
        }


        // Базовый класс заявки
        public class RequestBase
        {

            public OwnType OwnType { get; set; }
            public HouseType HouseType { get; set; }
            public District District { get; set; }
            public BuildingMaterial Material { get; set; }
            public string AdditionalConditions { get; set; }
            public bool IsSpecial { get; set; }

            public RequestBase(OwnType ownType, HouseType houseType, District district, BuildingMaterial material, string additionalConditions, bool isSpecial = false)
            {
                OwnType = ownType;
                HouseType = houseType;
                District = district;
                Material = material;
                AdditionalConditions = additionalConditions;
                IsSpecial = isSpecial;
            }

            public override string ToString()
            {
                return $@"
Тип владения: {OwnType.ToLocalizedString()}
Тип жилья: {HouseType.ToLocalizedString()}
Район: {District.ToLocalizedString()}
Материал: {Material.ToLocalizedString()}
Дополнительные условия: {AdditionalConditions}";
            }
        }

        // Заявка на покупку/аренду
        public class PurchaseRequest : RequestBase
        {
            public Range<decimal> PriceRange { get; set; }

            public PurchaseRequest(OwnType requestType, HouseType houseType, District district, BuildingMaterial material, Range<decimal> priceRange, string additionalConditions, bool isSpecial)
                : base(requestType, houseType, district, material, additionalConditions, isSpecial)
            {
                PriceRange = priceRange;
            }

            public override string ToString()
            {
                return $@"
Купля/Продажа: {"Купля"}
Тип владения: {OwnType.ToLocalizedString()}
Тип жилья: {HouseType.ToLocalizedString()}
Район: {District.ToLocalizedString()}
Диапазон цены: {PriceRange} руб.
Материал: {Material.ToLocalizedString()}
Дополнительные условия: {AdditionalConditions}";
            }

        }

        // Заявка на продажу/аренду
        public class SaleRequest : RequestBase
        {
            private decimal _price;
            private int _floor;
            private double _totalArea;
            private double _livingArea;
            private double _kitchenArea;
            private int _floors;
            private string _address;
            private DateTime _constructionDate;
            private DateTime _lastRepairDate;

            public decimal Price
            {
                get => _price;
                set
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Цена должна быть больше нуля.");
                    }
                    _price = value;
                }
            }

            public string Address
            {
                get => _address;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("Адрес не может быть пустым.");
                    _address = value;
                }
            }
            public int Floor
            {
                get => _floor;
                set
                {
                    if (value <= 0 || value > Floors)
                    {
                        throw new ArgumentException("Этаж должен быть больше нуля и не больше этажности дома.");
                    }
                    _floor = value;
                }
            }

            public double TotalArea
            {
                get => _totalArea;
                set
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Общая площадь должна быть больше нуля.");
                    }
                    _totalArea = value;
                }
            }

            public double LivingArea
            {
                get => _livingArea;
                set
                {
                    if (value <= 0 || value >= TotalArea || value + KitchenArea > TotalArea)
                    {
                        throw new ArgumentException("Жилая площадь должна быть больше нуля и меньше общей площади (В сочетании с площадью кухни).");
                    }
                    _livingArea = value;
                }
            }

            public double KitchenArea
            {
                get => _kitchenArea;
                set
                {
                    if (value <= 0 || value >= TotalArea || value + LivingArea > TotalArea)
                    {
                        throw new ArgumentException("Площадь кухни должна быть больше нуля и меньше общей площади (В сочетании с жилой площадью).");
                    }
                    _kitchenArea = value;
                }
            }

            public int Floors
            {
                get => _floors;
                set
                {
                    if (value <= 0 || value >= 163)
                    {
                        throw new ArgumentException("Этажность дома должна быть больше нуля и меньше 163.");
                    }
                    _floors = value;
                }
            }

            public DateTime ConstructionDate
            {
                get => _constructionDate;
                set
                {
                    ValidateDate(value, "Дата постройки");
                    _constructionDate = value;
                }
            }

            public DateTime LastRepairDate
            {
                get => _lastRepairDate;
                set
                {
                    ValidateDate(value, "Дата последнего ремонта");

                    if (_constructionDate != default && value < _constructionDate)
                    {
                        throw new ArgumentException("Дата последнего ремонта не может быть раньше даты постройки.");
                    }

                    _lastRepairDate = value;
                }
            }

            public bool HasElevator { get; set; }
            public bool HasGarbageChute { get; set; }
            public bool HasPhoneCable { get; set; }

            public SaleRequest(
                OwnType requestType,
                HouseType houseType,
                District district,
                BuildingMaterial material,
                decimal price,
                int floor,
                double totalArea,
                double livingArea,
                double kitchenArea,
                int floors,
                DateTime constructionDate,
                DateTime lastRepairDate,
                string address,
                bool hasElevator,
                bool hasGarbageChute,
                bool hasPhoneCable,
                string additionalConditions,
                bool isSpecial)
                : base(requestType, houseType, district, material, additionalConditions, isSpecial)
            {
                Price = price;
                Floors = floors;
                Floor = floor;
                TotalArea = totalArea;
                LivingArea = livingArea;
                KitchenArea = kitchenArea;
                ConstructionDate = constructionDate;
                LastRepairDate = lastRepairDate;
                Address = address;
                HasElevator = hasElevator;
                HasGarbageChute = hasGarbageChute;
                HasPhoneCable = hasPhoneCable;
            }

            private void ValidateDate(DateTime date, string fieldName)
            {
                if (date.Year < 1600 || date.Year > DateTime.Now.Year)
                {
                    throw new ArgumentException($"{fieldName} должна быть между 1600 и текущим годом.");
                }
            }

            public override string ToString()
            {
                string formatDate(DateTime date) => date.ToString("dd.MM.yyyy");


                return $@"
{(IsSpecial ? "СПЕЦИАЛЬНОЕ ПРЕДЛОЖЕНИЕ!" : "")}
Купля/Продажа: {"Продажа"}
Тип владения: {OwnType.ToLocalizedString()}
Тип жилья: {HouseType.ToLocalizedString()}
Район: {District.ToLocalizedString()}
Цена: {Price:N0} руб.
Материал: {Material.ToLocalizedString()}
Этаж: {Floor}
Общая площадь: {TotalArea:N2} м²
Жилая площадь: {LivingArea:N2} м²
Площадь кухни: {KitchenArea:N2} м²
Этажность дома: {Floors}
Дата постройки: {formatDate(ConstructionDate)}
Дата последнего ремонта: {formatDate(LastRepairDate)}
Адрес: {Address}
Лифт: {(HasElevator ? "Да" : "Нет")}
Мусоропровод: {(HasGarbageChute ? "Да" : "Нет")}
Телефонный кабель: {(HasPhoneCable ? "Да" : "Нет")}
Дополнительные условия: {AdditionalConditions}";
            }

        }
    }
    public static class RequestAnalyzer
    {
        public static string GetCategoryStatistics(IEnumerable<Requests.RequestBase> requests, bool includeOwnType = true)
        {
            if (!requests.Any())
                return "Нет доступных заявок для анализа.";

            // Метод для подсчета популярности значений по категории
            string AnalyzeCategory<T>(Func<Requests.RequestBase, T> selector, string categoryName) where T : Enum
            {
                var grouped = requests
                    .GroupBy(selector)
                    .Select(g => new { Value = g.Key, Count = g.Count() })
                    .OrderByDescending(g => g.Count);

                int maxCount = grouped.First().Count;
                var mostPopular = grouped
                    .Where(g => g.Count == maxCount)
                    .Select(g => g.Value.ToLocalizedString());

                return $"{categoryName}: {string.Join(", ", mostPopular)} (Количество заявок: {maxCount})";
            }

            // Формируем список результатов
            var results = new List<string>();

            // Добавляем категории в зависимости от флага
            if (includeOwnType)
            {
                results.Add(AnalyzeCategory(r => r.OwnType, "Тип владения"));
            }

            results.Add(AnalyzeCategory(r => r.HouseType, "Тип жилья"));
            results.Add(AnalyzeCategory(r => r.District, "Район"));
            results.Add(AnalyzeCategory(r => r.Material, "Материал"));

            return string.Join("\n", results);
        }
    }

}
