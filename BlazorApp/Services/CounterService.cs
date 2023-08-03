
using System.Reactive.Subjects;

namespace BlazorApp.Services
{
    public class CounterService
    {
        public BehaviorSubject<int> currentCount = new BehaviorSubject<int>(1);
    }
}
