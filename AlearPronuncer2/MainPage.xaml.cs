using AlertPronuncer.Servcies;

namespace AlearPronuncer2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly IMessagePronuncer messagePronuncer;

        public MainPage(IMessagePronuncer messagePronuncer)
        {
            InitializeComponent();
            this.messagePronuncer = messagePronuncer;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            Task.Run(async () => {
                await messagePronuncer.SpeakAsync("Hello from speaking service");
            });

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
