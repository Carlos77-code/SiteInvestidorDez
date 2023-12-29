
# Projeto em CSharp com Selenium, utilizando NUnit e .Net 8.0(atualizei o .Net pois agora o Selenium suporta) 


## Status do Projeto
> Status do Projeto: Em desenvolvimento :warning:

## Tarefas em aberto
- [x] Tarefa 1: Criar estrutura do projeto.
- [x] Tarefa 2: Criar método para abrir/fechar o navegador e acessar o site Investidor 10.
- [x] Tarefa 3: Criar as interações de clique e verificação da Home page.
- [x] Tarefa 4: Criar buscas de multiplas cotas e ações.
- [x] Tarefa 5: Criar validações de multiplas cotas e ações.
- [x] Tarefa 6: Criar metodo de validação em lote com grandes volumes (via arquivos simulando uma DataBase).
- [x] Tarefa 7: Criar logica para identificar se o valor do dividendo é o mesmo pago no mês anterior.
- [] Tarefa 8: Criar metodo para extrair as informações da tabela para uma planilha em excel.
- [] Tarefa 9: Criar metodo para extrair as informações da tabela para um banco de dados SQL.

## Descrição do Projeto
Este projeto tem por motivação realizar a automação de consultas e extração de dados em diversas Ações/Cotas no Automação do site Investidor 10.



## Linguagens e libs utilizadas :books:
- .Net 8.0
    - Selenium até o momento só suporta até o .Net 8.0
- NUnit
    - É um framework para testes unitários e suporta todas as linguagens da plataforma .Net.
- CSharp
    - Será a linguagem que utilizaremos.
## Rodando os testes

Para rodar a automação, execute o seguinte comando

```bash
  F5 (irá rodar os testes em modo debug)
  ctrl + F5 (irá rodar)
  Test Explorer (nele dá para escolher se roda somente um teste ou todos que tiver)
```
### Problema encontrado:
- O Selenium não suportava o .Net 6, 7 e 8
- O arquivo .vsidx fica me impedindo de commitar as alterações

  
### Resolvendo problemas
- Selenium começou a suportar os .Net 6, 7 e 8
- Precisei criar e inserir o arquivos .vsidx dentro do .gitignore para conseguir commitar

### Participante:
- Carlos L. Fernandes
|name|email|Cargo|
| -------- | -------- | -------- 
|Carlos L. Fernandes|carloslimafernandes@hotmail.com|QA|
