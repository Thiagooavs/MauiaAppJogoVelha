namespace MauiaAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";
        int cont = 0;
        int cc; 
        
        public MainPage()
        {
            InitializeComponent();

        }
         
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;//Fala que o sender é um botão
            cc = cont;
            cont = cc + 1;
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

            //X ganhou 
            if(btn10.Text == "X" &&
               btn11.Text == "X" &&
               btn12.Text == "X")
            {
                DisplayAlert ("Parabens!!", "O X ganhou", "Fechar");
            }
            else if (btn20.Text == "X" &&
                    btn21.Text == "X" &&
                    btn22.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
            }
            else if (btn30.Text == "X" &&
                    btn31.Text == "X" &&
                    btn32.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
            }
            else if (btn10.Text == "X" &&
                   btn20.Text == "X" &&
                   btn30.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
            }
            else if (btn11.Text == "X" &&
                   btn21.Text == "X" &&
                   btn31.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
            }
            else if (btn12.Text == "X" &&
                   btn22.Text == "X" &&
                   btn32.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
            }
            else if (btn10.Text == "X" &&
                   btn21.Text == "X" &&
                   btn32.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
            }
            else if (btn12.Text == "X" &&
                   btn21.Text == "X" &&
                   btn30.Text == "X")
            {
                DisplayAlert("Parabens!!", "O X ganhou", "Fechar");
            }
            //O ganhou
            if (btn10.Text == "O" &&
               btn11.Text == "O" &&
               btn12.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
            }
            else if (btn20.Text == "O" &&
                    btn21.Text == "O" &&
                    btn22.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
            }
            else if (btn30.Text == "O" &&
                    btn31.Text == "O" &&
                    btn32.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
            }
            else if (btn10.Text == "O" &&
                   btn20.Text == "O" &&
                   btn30.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
            }
            else if (btn11.Text == "O" &&
                   btn21.Text == "O" &&
                   btn31.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
            }
            else if (btn12.Text == "O" &&
                   btn22.Text == "O" &&
                   btn32.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
            }
            else if (btn10.Text == "O" &&
                   btn21.Text == "O" &&
                   btn32.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
            }
            else if (btn12.Text == "O" &&
                   btn21.Text == "O" &&
                   btn30.Text == "O")
            {
                DisplayAlert("Parabens!!", "O O ganhou", "Fechar");
            }

            if (cont == 9)
            {
                DisplayAlert("Empate!!", "Ambos são péssimos", "Fechar");
            }






        }//Fecha Button_Clicked
    }

}
