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


        public static int ToInt32<T>(this T num) => Convert.ToInt32(num);

        public static short ToInt16<T>(this T num) => Convert.ToInt16(num);

        public static long ToInt64<T>(this T num) => Convert.ToInt64(num);
    }
}