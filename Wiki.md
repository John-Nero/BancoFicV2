 Program:
 a classe program é executada quando a aplicação é inicializada. O método main será chamado, instanciando a classe Login.
_____________________________________________________________________________________________________________________________
Login:
 O que é?
 É um Forms que quando chamado ativa um construtor que inicializa os processos para funcionamento.
 
 
 O que faz?
 Quando inicializado, o método construtor da classe executa o método InitializeComponents() criando a UI e disponibilizando
 4 botões que ficam no aguardo de um clique: Login de Poupança, Login de Corrente, Criar Corrente, Criar Poupança.
 Cada botão possui seu próprio método que ao ser executado instanciará um Forms conforme o botão 
 clicado(criar conta corrente/poupança ou login corrente/poupança) ao todo tendo 4 telas disponíveis para acesso.
_____________________________________________________________________________________________________________________________
Telas de login:

 O que são?
 É um Forms que quando chamado ativa o construtor que inicializa os processos para funcionamento para logar nas contas que já foram criadas e registradas no sistema.
 
 O que faz?
 Quando inicializado o método construtor da classe executa o método InitializeComponents() criando a UI e disponibilizando
 dois campos, um para selecionar a agência e outro para digitar o número de conta, também disponibiliza um botão para acessar 
 a conta com os dados digitados nos campos acima, o botão possui um método próprio que ira procurar no arquivo de clientes
 uma conta que corresponda com os dados digitados, caso ele ache ira instanciar o Forms da próxima tela, caso contrario ira
 retornar uma mensagem de erro.
 Se o login for o LoginContaPoupanca ele ira procurar os dados no arquivo DadosDosClientesPoupanca e ira passar por parâmetro
 para o próximo Forms uma conta poupança. Mas se for o login LoginContaCorrente ele ira procurar os dados no arquivo
 DadosDosClientesCorrente e ira passar por parâmetro para o próximo Forms uma conta corrente.
_____________________________________________________________________________________________________________________________
Telas para Criar uma Conta:

 O que são?
 É um Forms que quando chamado ativa o construtor que inicializa os processos para funcionamento para Criar uma conta nova que
 diferirá de qualquer outra conta do mesmo tipo.
 
 O que faz?
 Quando inicializado o método construtor da classe executa o método InitializeComponents() criando a UI e disponibilizando 
 três campos, um para digitar o nome um para o CPF e outro campo para selecionar o estado, também disponibiliza um botão 
 para criar a conta e acessar o menu de opções de conta, o botão possui um método próprio que ira verificar se já existe uma
 conta com o mesmo CPF digitado, caso ele ache ira retornar uma mensagem de erro dizendo que o CPF já consta no sistema e que
 não é possível ter duas contas do mesmo tipo no mesmo CPF, caso não encontre e os campos estejam todos preenchidos ele ira
 instanciar uma conta nova e ira salvar ela no arquivo de clientes, sendo que se o botão for para criar uma conta poupança ele
 ira registrar essa nova conta no arquivo DadosDosClientesPoupanca, caso contrario ele ira registrar no arquivo
 DadosDosClientesCorrente depois disso ira prosseguir para a UI de OpcoesDeConta. 
_____________________________________________________________________________________________________________________________
Tela de Opcoes De Conta:

 O que são?
 É um Forms que quando chamado ativa o construtor que inicializa os processos para funcionamento.
 
 O que faz?
 Quando inicializado, o método construtor da classe executa o método InitializeComponents() criando a UI e disponibilizando
 4 botões que ficam no aguardo de um clique: Deposito, Emprestimo, Saque e Transferencia.
 Cada botão possui seu próprio método que ao ser executado instanciará um Forms conforme o botão 
 clicado ao todo tendo 4 telas disponíveis para acesso.
______________________________________________________________________________________________________________________________
Deposito:

 O que são?
 É um Forms que quando chamado ativa o construtor que inicializa os processos para funcionamento e também as configurações
 de estilo e formatação da caixa de texto para valores.
 
 O que faz?
 Quando inicializado o método construtor da classe executa o método InitializeComponents() criando a UI e disponibilizando 
 um campo e um botão, o campo possui um bloqueio para letras e caracteres especiais que retorna um aviso caso seja digitado,
 o botão ira confirmar o valor a ser depositado e ira somar o valor ao saldo atual da conta, após isso retorna o usuário a 
 tela de opções.
______________________________________________________________________________________________________________________________
Emprestimo:

 O que são?
 É um Forms que quando chamado ativa o construtor que inicializa os processos para funcionamento e também as configurações
 de estilo e formatação da caixa de texto para valores.
 
 Quando inicializado o método construtor da classe executa o método InitializeComponents() criando a UI e disponibilizando 
 um campo e um botão, o campo possui um bloqueio para letras e caracteres especiais que retorna um aviso caso seja digitado,
 o botão ira confirmar o valor do empréstimo e caso ele seja menor ou igual ao valor de limite de empréstimo da conta ele 
 ira retirar do limite e somar o valor ao saldo atual da conta, após isso retorna o usuário a tela de opções.
______________________________________________________________________________________________________________________________
 Saque:
  
 O que são?
  É um Forms que quando chamado ativa o construtor que inicializa os processos para funcionamento e também as configurações
  de estilo e formatação da caixa de texto para valores.
 
 O que faz?
  Quando inicializado o método construtor da classe executa o método InitializeComponents() criando a UI e disponibilizando 
  um campo e um botão, o campo possui um bloqueio para letras e caracteres especiais que retorna um aviso caso seja digitado,
  o botão ira confirmar o valor a ser sacado e ira subtrair o valor do saldo atual da conta, após isso retorna o usuário a 
  tela de opções.
______________________________________________________________________________________________________________________________
 Transferencia:
  
 O que são?
  É um Forms que quando chamado ativa o construtor que inicializa os processos para funcionamento e também as configurações
  de estilo e formatação da caixa de texto para valores.
 
 O que faz?
  Quando inicializado o método construtor da classe executa o método InitializeComponents() criando a UI e disponibilizando 
  três campo, um radioButton e um botão, nos campos o usuário deve digitar os dados da conta que deseja transferir sendo esses
  dados: numero de agência, numero de conta e o valor para transferência. Após isso ele seleciona o tipo de conta no Radiobutton
  sendo as opções de escolha: conta poupança e conta corrente, para finalizar o processo deve ser pressionado o botão de 
  confirmação, caso os dados digitados não existirem no sistema ele ira retornar um erro para o usuário, do contrário o botão ira
  confirmar o valor a ser transferido e ira subtrair o valor do saldo atual da conta e depositar o valor na conta desejada,
  após isso retorna o usuário a tela de opções.
______________________________________________________________________________________________________________________________
