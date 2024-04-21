Projeto para desenvolver em C# com o Windows forms, um ERP para gestão de uma petshop. TO DO solicitado.

funções essenciais{
        Cadastro do cliente{
            um cliente pode possuir mais de um pet.
            Cadastro do pet precisa estar vinculado a um cliente
                Informações necessárias do cliente{
                    - Nome;
                    - telefone;
                    - endereço (opcional);
                    - lista de pets;
					- Observações;
                }
        }

        Cadastro de pet{
            Pet precisa ter um tutor (dono);
            Informações necessárias para o pet{
                - tutor;
                - Nome do pet;
                - raça;
                - vacinado;
                - tipo de pelagem;
                - porte;
                - alergia (sim/não);
                - data de nascimento (aproximada);
                - observações;
            }
        }
        
        Financeiro{
            Lançamento de despesas{
                criar campos para lançar despesas e quais tipos(compras de insumos, energia elétrica, água, etc..);
            }

            relatório geral{
                Poder escolher o período;
                Exibir totalizadores (despesa, receitas e lucro/prejuízo);
                Constar valores da tela de procedimentos (vendas);
            }
        }

        
        Orden De serviço diárias{
            Agendamento da ordem (deixar em aberto){
                - valor Cobrado;
                - Procedimentos solicitados;
                - pet e cliente;
                - Informações do cadastro do pet carregadas na tela apenas para visualização;
                - Insumos que serão utilizados(lista dos produtos que foram cadastrados);
			Insumos será uma tabela separada no banco, relacionando com a tabela de Pedidos. 
   			No sistema, os insumos poderão ser inseridos em uma ListBox na tela.
                - data/horário;
            }

            Ordem De Serviço {
                listar ordens em aberto;
                ao dar 2 cliques, abrir tela para finalização do pedido;
                informações visiveis{
                    - cliente e contato;
                    - pet;
                    - procedimentos;
                    - horário;
                }
            }

            finalização da ordem de serviço{
                listar todas as informações antes preenchidas na ordem;
                campo para inserir a quantidade de cada insumo que foi utilizado(baixar do estoque quando o pedido for finalizado);
                valor recebido;
                finalizar ordem (lançar valores no financeiro e baixar estoques.);
                Cancelar ordem (exclui o pedido sem alterações de valores/estoque, retira da tela);
            }
        }

        Insumos{
            Cadastro de insumos{
                Campo para nome do Insumos;
                cod barras;
                Marca;
                Custo (quanto pagou);
                Quantidade da embalagem (quanto vem em 1 un);
                ativo(checkbox indicando se há ou não disponível, se desmarcada, não aparecer na tela de agendamento de pedidos);
            }

            Lista de insumos disponíveis{
                lista os insumos marcados como ativos com estoque e custo;
            }

            entrada de insumos{
                inserção de insumos previamente cadastrados{
                    deve-se poder dar entrada de quantidades e custos, alterando a informações no cadastro e lista;
                    multiplica custo X quantidade para lançar como despesa de compra de insumo no financeiro;
                }
            }

            ajuste de insumos{
                qual o insumo;
                entrada ou saída de estoque;
                quantidade para lançar;
            }
        }
    }
