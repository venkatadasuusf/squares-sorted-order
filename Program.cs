using System;

namespace squares_sorted_order
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] input_array = { -7, -3, 2, 3, 11 };
                int[] output_array = new int[input_array.Length];

                int i = input_array.Length - 1;
                int start_ind = 0;
                int end_ind = input_array.Length - 1;

                while (start_ind <= end_ind)
                {
                    if ((input_array[start_ind] * input_array[start_ind]) > (input_array[end_ind] * input_array[end_ind]))
                    {
                        output_array[i] = input_array[start_ind] * input_array[start_ind];
                        i--;
                        start_ind++;
                    }
                    else
                    {
                        output_array[i] = input_array[end_ind] * input_array[end_ind];
                        i--;
                        end_ind--;
                    }
                }

                foreach (var item in output_array)
                {
                    Console.Write(item + " ");
                }



            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");

            }   // End of catch
        }
    }
}
