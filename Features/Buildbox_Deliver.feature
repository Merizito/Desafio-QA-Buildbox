#Language pt-BR

@Deliver
Funcionalidade: Cadastrar novo entregador
Como um usuário da Buger Eats
Quero poder me cadastrar
Para conseguir realizar entregas

Contexto: 
Dado que estou na página de cadastro
E estou visualizando o formulário de cadastro

#Realizar um novo cadastro através do caminho feliz.
Cenário: Cadastro com sucesso #1
Quando insiro valores nos campos da seção "Dados" corretos e válidos pelo sistema
E insiro valores nos campos da seção "Endereço" corretos e válidos pelo sistema
E seleciono ao menos um "Método de entrega" 
E realizo o upload de uma "Foto da CNH" válida
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá salvar um novo cadastro

#Tentar cadastrar inserindo espaços em brancos.
Cenário: Cadastro sem sucesso #1
Quando insiro espaços em branco em todos os campos
E seleciono ao menos um "Método de entrega"
E realizo o upload de uma "Foto da CNH" válida
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá me apresentar um erro ao tentar salvar um novo cadastro

#Tentar cadastrar inserindo espaços em brancos somente na seção "Dados".
Cenário: Cadastro sem sucesso #2
Quando insiro espaços em branco nos campos da seção "Dados"
E insiro valores nos campos da seção "Endereço" corretos e válidos pelo sistema
E seleciono ao menos um "Método de entrega"
E realizo o upload de uma "Foto da CNH" válida
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá me apresentar um erro ao tentar salvar um novo cadastro

#Tentar cadastrar inserindo espaços em brancos somente na seção "Endereço".
Cenário: Cadastro sem sucesso #3
Quando insiro valores nos campos da seção "Dados" corretos e válidos pelo sistema
E insiro espaços em branco nos campos da seção "Endereço"
E seleciono ao menos um "Método de entrega"
E realizo o upload de uma "Foto da CNH" válida
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá me apresentar um erro ao tentar salvar um novo cadastro


#Tentar cadastrar sem selecionar um Método de Entrega.
Cenário: Cadastro sem sucesso #4
Quando insiro valores nos campos da seção "Dados" corretos e válidos pelo sistema
E insiro valores nos campos da seção "Endereço" corretos e válidos pelo sistema
E não seleciono nenhum "Método de entrega"
E realizo o upload de uma "Foto da CNH" válida
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá me apresentar um erro ao tentar salvar um novo cadastro


#Tentar cadastrar realizando upload de um arquivo que não seja uma imagem.
Cenário: Cadastro sem sucesso #5
Quando insiro valores nos campos da seção "Dados" corretos e válidos pelo sistema
E insiro valores nos campos da seção "Endereço" corretos e válidos pelo sistema
E seleciono ao menos um "Método de entrega"
E realizo o upload de um arquivo que não seja uma imagem
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá me apresentar um erro ao tentar salvar um novo cadastro


#Tentar cadastrar sem realizar upload.
Cenário: Cadastro sem sucesso #6
Quando insiro valores nos campos da seção "Dados" corretos e válidos pelo sistema
E insiro valores nos campos da seção "Endereço" corretos e válidos pelo sistema
E seleciono ao menos um "Método de entrega"
E não realizo upload de um arquivo
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá me apresentar um erro ao tentar salvar um novo cadastro

#Tentar cadastrar inserindo valores inválidos nos campos da Seção "Dados". (Ex: texto nos campos 'CPF' e 'Whatsapp')
Cenário: Cadastro sem sucesso #7
Quando insiro valores não válidos nos campos da seção "Dados"
E insiro valores nos campos da seção "Endereço" corretos e válidos pelo sistema
E seleciono ao menos um "Método de entrega"
E realizo o upload de uma "Foto da CNH" válida
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá me apresentar um erro ao tentar salvar um novo cadastro

#Tentar cadastrar inserindo um CEP não válido (Ex: texto no campo CEP)
Cenário: Cadastro sem sucesso #8
Quando insiro valores nos campos da seção "Dados" corretos e válidos pelo sistema
E insiro um CEP não válido
E seleciono ao menos um "Método de entrega"
E realizo o upload de uma "Foto da CNH" válida
E clico no botão "Cadastre-se para fazer entregas"
Então o sistema deverá me apresentar um erro ao tentar salvar um novo cadastro
