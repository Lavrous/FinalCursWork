using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCursWork
{
    public partial class ProfitComparisonForm : Form
    {
        public ProfitComparisonForm()
        {
            InitializeComponent();
        }

        private void ButtonCompare_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start1 = datePickerStart1.Value.Date;
                DateTime end1 = datePickerEnd1.Value.Date;
                DateTime start2 = datePickerStart2.Value.Date;
                DateTime end2 = datePickerEnd2.Value.Date;

                if (start1 > end1 || start2 > end2)
                {
                    MessageBox.Show("Дата начала не может быть позже даты окончания.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal profit1 = MainForm.Records
                    .Where(record => record.Date >= start1 && record.Date <= end1)
                    .Sum(record => record.Profit);

                decimal profit2 = MainForm.Records
                    .Where(record => record.Date >= start2 && record.Date <= end2)
                    .Sum(record => record.Profit);

                string comparison = profit1 == profit2
                    ? "Прибыль за оба периода равна."
                    : profit1 > profit2
                        ? $"Прибыль за первый период на {profit1 - profit2:C} больше."
                        : $"Прибыль за второй период на {profit2 - profit1:C} больше.";

                MessageBox.Show(
                    $"Прибыль за первый период: {profit1:C}\n" +
                    $"Прибыль за второй период: {profit2:C}\n" +
                    $"{comparison}",
                    "Сравнение прибыли",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
