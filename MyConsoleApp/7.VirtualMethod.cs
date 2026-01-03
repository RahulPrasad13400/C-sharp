namespace MyConsoleApp
{
    public class VirtualMethod
    {
        public int Calculator(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (shallBeAdded(number))
                {
                    sum += number;
                }
            }
            return sum;
        }
        protected virtual bool shallBeAdded(int number)
        {
            return true;
        }
    }

    public class AddOnlyPositives : VirtualMethod
    {
        protected override bool shallBeAdded(int number)
        {
            if(number > 0)
            {
                return true;
            }
            return false;
        }
    }
}
