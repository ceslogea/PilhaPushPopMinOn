namespace PilhaPushPopMin
{
    /// <summary>
    /// Utilizaria utilizando uma e um contador para controlar a posição do próximo elemento, 
    /// esta classe disponibliza as funcionalidades 
    /// Push para inserir dados na pilha, 
    /// Pop para remover o elemento do topo, 
    /// e Min para verificar qual foi o menor elemento inserido.
    /// 
    /// Ao inserir um número na pilha, verifica-se que o número anterior inserido, é menor que o número a ser inserido,
    /// neste caso, através de uma variável auxiliar, realoco as posições do número a ser inserido, que é menor, logo
    /// o menor número estará sempre no topo da pilha.
    /// </summary>
    public class Pilha
    {
        internal int[] Arr;
        private int topIndex;

        /// <summary>
        /// Create object with Push, Pop, Min methods by order of O(1).
        /// </summary>
        /// <param name="size"></param>
        public Pilha(int size)
        {
            Arr = new int[size];
            topIndex = 0;
        }

        /// <summary>
        /// Push the element in stack, smaller numbers will be at the top of the stack.
        /// </summary>
        /// <param name="number">Integer</param>
        public void Push(int number)
        {
            if (topIndex > 0 && Min() < number)
            {
                //Invert the smaller number 'number' with the top element of the stack.
                var auxMenor = Pop();
                Arr[topIndex] = (number);
                topIndex++;
                Arr[topIndex] = (auxMenor);
            }
            else
                Arr[topIndex] = (number);

            topIndex++;
        }

        /// <summary>
        /// Remove the top of stack.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            topIndex--;
            var topElement = Arr[topIndex];
            Arr[topIndex] = 0;
            return topElement;
        }

        /// <summary>
        /// Reads the top element in the stack.
        /// </summary>
        /// <returns></returns>
        public int Min()
        {
            return Arr[topIndex - 1];
        }
    }
}
