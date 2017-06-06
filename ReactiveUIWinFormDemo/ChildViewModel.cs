using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ReactiveUIWinFormDemo
{
    public class ChildViewModel : ReactiveObject
    {
        [Reactive]
        public string Name { get; set; }
    }
}