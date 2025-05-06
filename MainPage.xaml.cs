namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int sorteado, itemIndex = -1;

        Roll dice = new Roll();
        Game jogo = new Game();
        public MainPage()
        {
            InitializeComponent();
        }
        private async void DiceButton_Clicked(object sender, EventArgs e)
        {
            itemIndex = NumPicker.SelectedIndex +1;
            if (itemIndex == -1)
            {
                await DisplayAlert("ALERTA", "ESCOLHA UM LADO!!!", "OK");
            }
            if (dice.SomaLadosOpostos >= 25)
            {
                await DisplayAlert("FIM DE JOGO", "A soma dos lados opostos atingiu o limite de 25 ou mais.\nO jogo acabou!", "OK");
                DiceButton.IsEnabled = false;
             
            }
            sorteado = dice.DiceRoller();
            

            if (jogo.CheckWinner(sorteado, itemIndex))
            {
                await Task.Delay(200);
                await DisplayAlert("Sorteio", $"Parabéns!!! \nCaiu {sorteado}", "OK");
            } else {
                 await Task.Delay(200);
                await DisplayAlert("Sorteio", $"QUE PENA!!! \nCaiu {sorteado}", "OK");
            }
            DiceImage.Source = dice.Image;
            VictoryLabel.Text = $"Vitorias: {jogo.PlayerPoint}";
            StreakLabel.Text = $"Sequência de Vitorias: {jogo.Streak}";
            SumSidesLabel.Text = $"Soma dos Lados Opostos: {dice.SomaLadosOpostos}";
            if (dice.SomaLadosOpostos >= 25)
            {
                await DisplayAlert("FIM DE JOGO", "A soma dos lados opostos atingiu o limite de 25 ou mais.\nO jogo acabou!", "OK");
                DiceButton.IsEnabled = false;
            }
        }
    } 
}

