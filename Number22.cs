namespace Assingment
{
    public class Number22
    {
        public static void size()
        {
            int test(int nums, int arr_size)
            {
                for (int i = 0; i < arr_size - 1; i++)
                {
                    if (nums[i] == 5 && nums[i] == nums[i + 1]) return 1;
                }
                return 0;
            }
        }
    }
}