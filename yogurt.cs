using System;


/*

Here's an outline of the solution for this problem:

1. Define variables: 
   - regularPrice = 1 burle (price of one yogurt)
   - promoPrice = b burles (price of two yogurts in promotion)
   - n (number of yogurts Maxim needs to buy)

2. Check if n is even or odd:
   - If n is even, Maxim can buy yogurts in pairs and use the promotion for every pair.
   - If n is odd, Maxim can buy yogurts in pairs using the promotion for (n-1) yogurts and then buy one additional yogurt at regular price.

3. Calculate the minimum cost:
   - For even n: Calculate the cost of buying all yogurts at regular price vs. using the promotion for half the yogurts and buying the rest at regular price.
   - For odd n: Calculate the cost of buying (n-1) yogurts using the promotion and one yogurt at regular price vs. buying all yogurts at regular price.

4. Return the minimum cost.
*/

class Program
{
  static void Main() {
    int x = 10;
    int y = 25;
    int z = x + y;

    Console.Write("Sum of x + y = "+ z);
  }
}
