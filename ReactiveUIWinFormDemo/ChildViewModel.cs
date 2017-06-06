using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WindowsFormsApplication1
{
    public class ChildViewModel : ReactiveObject
    {
        [Reactive]
        public string Name { get; set; }
    }
}