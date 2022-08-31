#Language pt-BR

@home
Funcionalidade: Navegar na página home
Como um usuário da Buger Eats
Quero poder visualizar o conteúdo da página inicial
Para ter acesso as suas funcionalidades

Contexto:
Dado Que estou na página inicial
E estou visualizando o conteúdo da página inicial

Cenário: Verificar se a página inicial está sendo exibida corretamente
Quando a página inicial carregar
Então Os elementos e botão de cadastro devem ser exibidos

Cenário: Navegar até a tela de cadastro
Quando a página inicial carregar
E clicar no botão "Cadastre-se para fazer entregas"
Então o sistema deve exibir a página de cadastro
	