using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    class BinaryInsert
    {
        public List<int> list;
        public int iterations;
        public TimeSpan timeElapsed;

        public void Start(int its)
        {
            list = new List<int>();
            iterations = its;
        }

        void Insert(int value)
        {
            int insertBefore = 0; //index we'll insert our item into
            
            bool foundPlace = false; //used to control the main loop

            int min = 0; //min index of our current search progress
            int max = list.Count - 1; //max index of our current search progress

            int pivot; //midway between min and max

            //Handle list with 0 items
            if (max < 0) foundPlace = true;

            while (foundPlace == false)
            {
                //Get the midway point between min and max
                pivot = (int)Math.Floor((max - min) / 2f) + min;

                //if our value lies between the values of the min and max positions
                if (list[min] < value && value < list[max])
                {
                    //compare our value to the pivot value

                    //if our value is less than the pivot value
                    if (value < list[pivot])
                    {
                        //our current known max must be <= pivot
                        max = pivot;
                    }
                    else if (value > list[pivot]) //value is greater than pivot value
                    {
                        //our current known min must be >= pivot
                        min = pivot;
                    }
                    else //value is equal to pivot value
                    {
                        foundPlace = true;
                        insertBefore = pivot;
                    }

                    //if there are <= 1 values between min and max
                    if (max - min <= 2)
                    {
                        //if our value is less than the min value 
                        if (value <= list[min])
                        {
                            //it goes before min
                            foundPlace = true;
                            insertBefore = min;
                        }
                        else if (value > list[max])//value is greater than max
                        {
                            //it goes after max
                            foundPlace = true;
                            insertBefore = max + 1;
                        }
                        else //value is greater than min value and less than max value
                        {
                            foundPlace = true;

                            //if there is a middle value between min and max AND our value is less than or equal to max
                            if (max - min == 2 && value <= list[max - 1])
                            {
                                //it goes before middle value
                                insertBefore = max - 1;
                            }
                            else
                            {
                                //it goes before max
                                insertBefore = max;
                            }
                        }
                    }
                }
                else if (value <= list[min])//value is less than or equal to min value
                {
                    //it goes before min
                    foundPlace = true;
                    insertBefore = min;
                }
                else if (value >= list[max])//value is greater than or equal to max value
                {
                    //it goes after max
                    foundPlace = true;
                    insertBefore = max + 1;
                }
            }

            //if our value should go at the end
            if (insertBefore == list.Count)
            {
                list.Add(value);
            }
            else
            {
                list.Insert(insertBefore, value);
            }
        }

        public void StartValidate()
        {
            Random r = new Random();

            
            DateTime startInsert = DateTime.Now;
            for (int i = 0; i < iterations; i++)
            {
                Insert(r.Next(-iterations, iterations));
            }
            DateTime endInsert = DateTime.Now;

            timeElapsed = endInsert.Subtract(startInsert);
        }

        public void EndValidate()
        {
            bool success = true;
            for (int i = 0; i < iterations - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    success = false;
                    break;
                }
            }
        }
    }
}
