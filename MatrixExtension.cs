using System;
namespace CS_HOMEWORK_2
{
    using System.Linq;
    using Test;

    internal static class ExtensionMethod
    {
        public static DiagonalMatrix Add(this DiagonalMatrix firstMatrix, DiagonalMatrix secondMatrix)
        {
            int[] _firstDiagonal = firstMatrix.diagonalNumbers;
            int[] _secondDiagonal = secondMatrix.diagonalNumbers;
            int[] _paddedArray;
            int[] _sumedArray;

            if (_firstDiagonal.Length < _secondDiagonal.Length)
            {
                _paddedArray = new int[_secondDiagonal.Length];

                Array.Copy(_firstDiagonal, _paddedArray, _firstDiagonal.Length);

                _sumedArray = new int[_paddedArray.Length];

                _sumedArray = _secondDiagonal.Zip(_paddedArray, (x, y) => x + y).ToArray();
                //for (int i = 0; i < _paddedArray.Length; i++)
                //{
                //    _sumedArray[i] = _paddedArray[i] + _secondDiagonal[i];
                //}

            }
            else if (_firstDiagonal.Length > _secondDiagonal.Length)
            {
                _paddedArray = new int[_firstDiagonal.Length];

                Array.Copy(_secondDiagonal, _paddedArray, _secondDiagonal.Length);

                _sumedArray = new int[_paddedArray.Length];
                //_sumedArray = _firstDiagonal.Zip(_paddedArray, (x, y) => x + y).ToArray();
                for (int i = 0; i < _paddedArray.Length; i++)
                {
                    _sumedArray[i] = _paddedArray[i] + _firstDiagonal[i];
                }
            }
            else
            {
                _sumedArray = new int[_firstDiagonal.Length];

                for (int i = 0; i < _firstDiagonal.Length; i++)
                {
                    _sumedArray[i] = _firstDiagonal[i] + _secondDiagonal[i];
                }
            }
            return new DiagonalMatrix(_sumedArray);
        }
    }
}
