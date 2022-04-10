using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**********************************************************************************
***********************************************************************************
* @file ce100_hw3_algo_lib_cs *
* @author Rabia SÜME *
* @date 10 April 2022 * 
*
* @brief <b> hw-3 Functions </b> *
*
* HW-3 Sample Lib Functions *
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
***********************************************************************************
***********************************************************************************/


namespace ce100_hw3_algo_lib_cs
{
    public class Class1
    {
        /* @name Longest Common Subsequence
         * 
         * @brief Returns length of LCS for R[0..a - 1], S[0..e - 1]
         * 
         * @param[in] fiA[\b String]  function index of  in the serie
         * 
         * @param[in] fiB[\b String] function index of  in the serie
         * 
         * @param[in] a[\b int] function index of  in the serie
         * 
         * @param[in] e[\b int] function index of  in the serie
         * 
         * @retval[\b char[]] return Longest Common Subsequence as a string.
         */


        // Returns length of LCS for X[0..m-1], Y[0..n-1]
        public static string LongestCommonSubsquence(string R, string S, int a, int e)
        {
            int[,] L = new int[a + 1, e + 1];

            // Following steps build L[m+1][n+1] in
            // bottom up fashion. Note that L[i][j]
            // contains length of LCS of X[0..i-1]
            // and Y[0..j-1]
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <= e; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        L[i, j] = 0;
                    }
                    else if (R[i - 1] == S[j - 1])
                    {
                        L[i, j] = L[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                    }
                }
            }

            // Following code is used to print LCS
            int index = L[a, e];


            // Create a character array
            // to store the lcs string
            string lcs = string.Empty;



            // Start from the right-most-bottom-most corner
            // and one by one store characters in lcs[]
            int k = a, l = e;
            while (k > 0 && l > 0)
            {
                // If current character in X[] and Y
                // are same, then current character
                // is part of LCS
                if (R[k - 1] == S[l - 1])
                {
                    // Put current character in result
                    lcs = R[k - 1] + lcs;

                    // reduce values of i, j and index
                    k--;
                    l--;
                    index--;
                }

                // If not same, then find the larger of two and
                // go in the direction of larger value
                else if (L[k - 1, l] > L[k, l - 1])
                { k--; }
                else
                { l--; }
            }
            return lcs;
        }







        /* @name Matrix Chain Order
        * 
        * @brief Matrix Ai has dimension fiA[i - 1] x fiA[i] for i = 1..n
          *
          * @param[in] fiA[\b int[]] function index of  in the serie
        * 
        * @param[in] r[\b int] function index of  in the serie
        * 
        * @param[in] s[\b int] function index of  in the serie
        * 
        * @retval[\b int] Return minimum count */


        // Matrix Ai has dimension p[i-1] x p[i]
        // for s = 1..m
        public static int MatrixChainOrder(int[] r, int s, int m)
        {

            if (s == m)
                return 0;

            int[,] min = new int[r.Length, r.Length];
            min[s, m] = int.MaxValue;
            // place parenthesis at different places
            // between first and last matrix, recursively
            // calculate count of multiplications for each
            // parenthesis placement and return the
            // minimum count
            for (int k = s; k < m; k++)
            {
                int count = MatrixChainOrder(r, s, k)
                            + MatrixChainOrder(r, k + 1, m)
                            + r[s - 1] * r[k] * r[m];

                if (count < min[s, m])
                    min[s, m] = count;
            }

            // Return minimum count
            return min[s, m];
        }

    }
}

