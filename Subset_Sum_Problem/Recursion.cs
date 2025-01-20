using System;

namespace Subset_Sum_Problem;

public class Recursion
{
    // Função para verificar se existe um subconjunto com a soma dada usando recursão
    public static bool isSubsetSumRec(int[] arr, int n, int sum)
    {
        // Caso base
        if (sum == 0)
            return true;
        if (n == 0)
            return false;

        if (arr[n - 1] > sum)
            return isSubsetSumRec(arr, n - 1, sum);
        
        // Verifica se a soma pode ser obtida incluindo ou excluindo o último elemento
        return isSubsetSumRec(arr, n - 1, sum) || isSubsetSumRec(arr, n - 1, sum - arr[n - 1]);
    }

    public static bool isSubsetSum(int[] arr, int sum) 
    {
        return isSubsetSumRec(arr, arr.Length, sum);
    }
}
