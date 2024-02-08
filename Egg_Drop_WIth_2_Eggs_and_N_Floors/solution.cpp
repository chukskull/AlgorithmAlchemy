class Solution {
public:
    int twoEggDrop(int n) {
      int i = 1; int count = 0;

      while( n > 0 ) {
          n -=i;
          i++;
          count++;
      }
      return count;
    }
};