using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ReactiveUIWinFormDemo
{
    public class ShellViewModel : ReactiveObject
    {
        public ShellViewModel()
        {
            var canExecute = this.WhenAnyValue(vm => vm.EnteredText)
                .Select(s => !string.IsNullOrWhiteSpace(s));

            Child = new ChildViewModel();
            OKCmd = ReactiveCommand.Create(Ok, canExecute);
        }

        [Reactive]
        public string EnteredText { get; set; }

        [Reactive]
        public string Status { get; set; }

        public void Ok()
        {
            Child.Name = "You entered: " + EnteredText;
        }

        public ReactiveCommand OKCmd { get; }

        public ChildViewModel Child { get; }
    }
}
