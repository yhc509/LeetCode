public class ProductOfNumbers {
    List<int> _list = new List<int>();

    public ProductOfNumbers() {
        _list.Clear();
    }
    
    public void Add(int num) {
        _list.Add(num);
    }
    
    public int GetProduct(int k) {
        int r = 1;
        for(int i = 1; i <= k; i++) {
            r *= _list[^i];
        }
        return r;
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */