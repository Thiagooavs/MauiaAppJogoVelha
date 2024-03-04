namespace MauiaAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";
        
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;//Fala que o sender é um botão

            disparador.IsEnabled = false;

            if(vez == "O")
            {
                disparador.Text = "O";
                vez = "X";

            }
            else
            {
                disparador.Text = "X";
                vez = "O";
            }//fecha if, que controla a vez do jogador

            if(btn10.Text == b)
        }//Fecha Button_Clicked
    }

}
