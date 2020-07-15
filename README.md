	Teste para Vaga .Net Core
	DDD, CLEAN CODE, SOLID

	Web Api Clientes

	Instrução para validação:

	* Mapear na camada de API, o arquivo appsettings.json para apontar para seu banco de dados sql
	* Coloque a camada API como "Set as Startup Project" 
	* Dar um Rebuild na solução.
	
	* Rodar o Migration na camada Infra pelo console. 
	  (Obs, não esquecer de setar a camada de infra no momento de rodar o console.)
	  add-migration AirLiquideMigration
	  update-database
	  
	  * Executar a camada de API.
	    
	* Abrir a documentação da APi no seguinte endereço: Colocar a porta do seu localhost
	  https://localhost:44323/swagger/index.html 
	  
	  Fazer todos os testes pela documentação do swagger,Postman ou sua ferramenta preferencial.
	
	* OBSERVAÇÃO: NÃO FOI IMPLEMENTADO NENHUMA SEGURANÇA NA API, PORÉM, TODOS PROJETOS QUE JA PARTICIPEI, 
	  APLIQUEI AS MELHORES PRATICAS DE MERCADO, COMO USO DO IDENTITY E JWT!
	
	*  Fazer os testes conforme solicitado!
	
	Abs
	
	
