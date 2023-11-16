
using System.Reactive.Subjects;

namespace BlazorAppWebAssembly.Services
{
    public class CounterService
    {
        public BehaviorSubject<int> currentCount = new BehaviorSubject<int>(1);
    }
}
