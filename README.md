# E-commerce treino
Para executar o projeto, abra **windows powershell como administrador** va ate a pasta src e execute o comando:`docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d`   

### URLS
- **Catalog API:** http://localhost:8000/swagger/index.html
- **Basket API:** http://localhost:8001/swagger/index.html
- **Discount API:** http://localhost:8002/swagger/index.html
- **Portainer:** http://localhost:9000/#!/2/docker/dashboard
- **PgAdmin:** http://localhost:5050/browser/


### Limpar ambiente
- Parar docker-compose: `docker-compose down`
- Remover todos containers: `docker rm -f $(docker ps -a -q)`
- Remover imagens: `docker rmi -f $(docker images -a -q)`
- Remover volumes: `docker volume rm $(docker volume ls -q)`
