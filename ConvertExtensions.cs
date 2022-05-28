namespace CommonLib
{
    public static class ConvertExtensions
    {
        /// <summary>
        /// Converte um número em um caracter correspondente a tabela ascii
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static async Task<char> DecodeAscii(this Task<int> i) => await Task.Run(async () => Convert.ToChar(await i));

        #region[CONVERT TO INT32]

        public static int ToInt(this decimal num) => Convert.ToInt32(num);

        public static int ToInt(this string num) => Convert.ToInt32(num);

        #endregion

        #region[CONVERT TO INT16]]

        public static short ToShort(this string num) => Convert.ToInt16(num);

        #endregion


        #region[CONVERT TO INT64]
        public static long ToLong(this string num) => Convert.ToInt64(num);

        #endregion
    }
}