using System.Windows.Forms;

namespace GreatSportEventApp
{
    public static class ValidatingControls
    {
        public static void SetTextLengthError(object sender, ErrorProvider errorProvider, int length)
        {
            TextBox textBox = (TextBox)sender;
            errorProvider.SetError(textBox, "");

            if (textBox.Text.Length > length)
            {
                errorProvider.SetError(textBox, "Превышено количество символов в строке!");
            }
        }

        public static void SetIntError(object sender, ErrorProvider errorProvider)
        {
            TextBox textBox = (TextBox)sender;
            errorProvider.SetError(textBox, "");

            if (!int.TryParse(textBox.Text, out int result) || result < 0)
            {
                errorProvider.SetError(textBox, "Ожидается положительное число!");
            }
        }
    }
}
