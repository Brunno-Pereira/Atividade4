using System;
using System.Net;

namespace ArvoreAVL {
	class ProgramaArvoreAVL {

		static void Main(string[] args) {

			Console.Write("Arvore avl! \n\n");

			ArvoreAVL arvoreAVL = new ArvoreAVL();	//Cria uma arvore nova

			int op, a;
			
			while (true) {
				//Enquanto uma  Arvore comum  nao esta necessariamente organizada, uma Arvore AVL está, por isso está "balanceada"

				//O balanco permite que o programa saiba qual caminho mais curto para percorrer ate o item
				//poupando tempo e esforço, nunca precisando checar a arvore inteira

				//O algoritmo vai  dividindo os  caminhos  necessarios em 2 para cada busca

				//Portanto, o custo de operacoes na arvore é LOGARITMO, ou seja, O(log(N))
				//Sendo N o numero de itens na arvore

				Console.WriteLine("1 - exibir a arvore");
				Console.WriteLine("2 - inserir um novo no");
				Console.WriteLine("3 - remover um no");
				Console.WriteLine("4 - percorrer em ordem");
				Console.WriteLine("5 - sair");
				Console.Write("escolha uma opcao: ");
				op = Convert.ToInt32(Console.ReadLine());

				if (op == 5) {
					break;
				}	

				switch (op) {
					case 1:
						arvoreAVL.Exibir();
						break;

					case 2:
						Console.Write("entre com a chave que sera inserida: ");
						a = Convert.ToInt32(Console.ReadLine());
						arvoreAVL.Inserir(a);	//O balanceamento ja é feito durante a insercao
						break;

					case 3:
						Console.Write("entre com a chave que sera removida: ");
						a = Convert.ToInt32(Console.ReadLine());
						arvoreAVL.Remover(a);	//Apos a  remocao, o balanceamento sera  feito, ainda nesta funcao
						break;

					case 4:
						arvoreAVL.PercorrerEmOrdem();	//Mostra os valores da arvore, em ordem. A arvore ja esta balanceada quando esta funcao é chamada
						break;
				}
			}
		}
	}
}