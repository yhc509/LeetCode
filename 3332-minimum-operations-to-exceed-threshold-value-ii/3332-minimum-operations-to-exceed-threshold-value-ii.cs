public class Solution {
    public int MinOperations(int[] nums, int k) {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        foreach(var e in nums) {
            queue.Enqueue(e, e);
        }
        int count = 0;
        while(queue.Count > 0 && queue.Peek() < k) {
            int x = queue.Dequeue();
            int y = queue.Count > 0 ? queue.Dequeue() : k;

            long newNum = x * 2;
            newNum += y;
            if(newNum < k) queue.Enqueue((int)newNum, (int)newNum);

            count++;
        }
        return count;
    }
}