# Projeto-Gravadora
Projeto desenvolvido para disciplina de Estrutura de Dados

*Descrição do Sistema*
Uma gravadora mantém cadastrados os seus artistas, suas canções e álbuns lançados.

Os dados dos artistas, das canções e álbuns são mantidos em vetores de tamanho fixo ordenados pela chave de ordenação, que para o vetor de artista é o código do artista, para
o vetor de canções é código da canção e para os álbuns é o código do álbum.
Os sistemas internos da gravadora precisam realizar algumas funcionalidades usando os dados dos artistas, álbuns e das canções para fins de controle ou mesmo funcionamento da
gravadora. Focalizando em atividades de busca e ordenação são propostas algumas implementações.

*Propostas de Implementação*

• Faça uma interface que permita ao usuário ter acesso a todas as funcionalidades implementadas. A chave de ordenação dos registros dos vetores pode ser definida automaticamente pelo sistema ou pelo usuário.

• O sistema deve permitir inserir, remover e alterar dados nos vetores, sempre mantendo a ordenação dos dados pela chave de ordenação definida para cada um deles. Não deve ser permitido que o usuário modifique essa chave, pois não pode haver repetição nos valores dessas chaves.

• Buscas a serem implementadas:
  o Deve ser possível buscar os dados de um certo elemento dos vetores pelo
código de ordenação. A busca ser usada deve ser a mais eficiente possível.
o Deve ser implementado um algoritmo de busca de O(logn) que dado a código
de um artista, retorne os dados desse artista bem como as canções compostas
por ele. Para a busca das canções pode ser usado um algoritmo de sua
escolha. As canções devem ser ordenadas pelo título.

  o Deve ser possível buscar todos os álbuns de um determinado artista/banda. O
algoritmo de busca pode ser o de sua escolha. Os resultados devem ser
ordenados pelos títulos dos álbuns usando um algoritmo com uma ordem
menor que quadrática.

  o Deve ser possível para a gravadora obter um relatório dos álbuns que serão
ainda lançados no ano corrente. Os resultados devem ser ordenados pelas
datas de lançamento usando o algoritmo mais adequado. A busca escolhida
deve ser também a mais adequada.

  o Deve ser possível para a gravadora obter para um determinado mês fornecido,
quais são os artistas aniversariantes. Pois no mês do aniversário todos os
trabalhos que o artista realizar ele tem o acréscimo de 20% no valor do seu
cachê. O resultado não precisa ser ordenado.

• Usando o conceito de tabelas Hash implementar:

  o Os diretores da gravadora tem de reunir rapidamente empresários para
reuniões principalmente quando os álbuns dos seus clientes estão prestes a
serem lançados. Dessa forma, defina e crie uma tabela hash que armazene os
e-mails dos empresários. A técnica de tratamento de colisão a ser usada é da
sua escolha. 
