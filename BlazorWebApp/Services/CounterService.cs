
using System.Reactive.Subjects;

namespace BlazorWebApp.Services
{
    public class CounterService
    {
        public BehaviorSubject<int> currentCount = new BehaviorSubject<int>(1);
    }
}
