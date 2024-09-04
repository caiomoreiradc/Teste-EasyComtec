public class Solution 
{
    public bool CheckSubarraySum(int[] numeros, int divisor) 
    {
        var indicesResto = new Dictionary<int, int> { { 0, -1 } };
        int soma = 0;

        for (int i = 0; i < numeros.Length; i++) 
        {
            soma = (soma + numeros[i]) % divisor;
            if (soma < 0) soma += divisor;

            if (indicesResto.TryGetValue(soma, out int indice)) 
            {
                if (i - indice > 1) return true;
            } 
            else 
                indicesResto[soma] = i;
        }
        return false;
    }
}
