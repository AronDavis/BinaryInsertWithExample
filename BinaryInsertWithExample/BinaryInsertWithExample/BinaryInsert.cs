﻿using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    class BinaryInsert
    {
        public List<int> list;
        public int iterations;
        public System.Diagnostics.Stopwatch timeElapsed;

        public void Start(int its)
        {
            list = new List<int>();
            iterations = its;
        }

        int maxValue, minValue, pivotValue;
        int insertBefore; //index we'll insert our item into
        bool foundPlace; //used to control the main loop
        int min; //min index of our current search progress
        int max; //max index of our current search progress
        int pivot; //midway between min and max
        void Insert(int value)
        {
            insertBefore = 0; //index we'll insert our item into
            
            foundPlace = false; //used to control the main loop

            min = 0; //min index of our current search progress
            max = list.Count - 1; //max index of our current search progress

            //Handle list with 0 items
            if (max < 0) foundPlace = true;

            while (!foundPlace)
            {
                //Get the midway point between min and max
                pivot = (max + min) / 2;

                minValue = list[min];
                maxValue = list[max];
                pivotValue = list[pivot];

                //if our value lies between the values of the min and max positions
                if (minValue < value && value < maxValue)
                {
                    //compare our value to the pivot value

                    //if our value is less than the pivot value
                    if (value < pivotValue)
                    {
                        //our current known max must be <= pivot
                        max = pivot;
                    }
                    else if (value > pivotValue) //value is greater than pivot value
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
                        foundPlace = true;

                        //if there is a middle value between min and max AND our value is less than or equal to the middle value
                        if (max - min == 2 && value <= pivotValue)
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
                else if (value <= minValue) //value is less than or equal to min value
                {
                    //it goes before min
                    foundPlace = true;
                    insertBefore = min;
                }
                else if (value >= maxValue) //value is greater than or equal to max value
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
            
            timeElapsed = new System.Diagnostics.Stopwatch();

            timeElapsed.Start();
            for (int i = 0; i < iterations; i++)
            {
                Insert(r.Next(-iterations, iterations));
            }
            timeElapsed.Stop();
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
