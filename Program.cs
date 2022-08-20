// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

// Solution: get number from target array -> run once through numbers list -> if target == numbers -> print numbers + Index for List[0] ex: {0;9} C target 
//  -> if target >= numbers -> loop through numbers list again until target - 9 = numbers[index] ex : target = 12 -> 12 > 9 so result = 9-12 -> index for 3.                                                           

List<int> numbersList = new List<int>{};  // INSERT NUMBERS TO USE AS SUM COMPONENTS.    

for(int i = 0; i < numbersList.Count; i++){
    Console.WriteLine("Index --- value");
    Console.WriteLine("     "+ i + " --- " + numbersList[i]);
}

List<int> targetList = new List<int>{};  // INSERT TARGET VALUE.
if (numbersList.Contains(targetList[0])) {
    Console.WriteLine("Two sum result for target " + targetList[0] + " is : " + "[" +numbersList.IndexOf(targetList[0]) +", " + numbersList.IndexOf(0) +"]." );
}

else {Console.WriteLine("Two sum result for target " + targetList[0] + " : [" + numbersList.IndexOf(targetList[0] - numbersList.Max()) +", " +(numbersList.IndexOf(numbersList.Max()))+"]" );

}