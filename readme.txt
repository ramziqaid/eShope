![Screenshot](https://github.com/ramziqaid/eShope/assets/26416031/af4fa728-e281-476d-ae5c-4f752591fbc5)
--mongo

docker run -d -p 27017:27017 --name ShoppingDB mongo

docker run -d --hostname my-rabbit --name some-rabbit -p 8015:15672 rabbitmq

connect databse
docker exec -it catalogdb /bin/bash
http://localhost:3000/databaseStats

use database
docker exec -it CatalogDb mongosh
 db.Products.insertMany( [ { "Name": "Asus Laptop", "Category": "Computers", "Summary": "Asus Laptop 16Giga RAM",
 "Description": "Asus Laptop 16Giga RAM", "ImageFile": "ImageFileb1", "Price": 170 }, { "Name": "HP Laptop", 
 "Category": "Computers", "Summary": "HP Laptop 16Giga RAM", "Description": "HP Laptop 16Giga RAM", "ImageFile": 
 "ImageFileb2", "Price": 200 }, { "Name": "HP Laptop", "Category": "Computers", "Summary": "HP Laptop 32Giga RAM",
 "Description": "HP Laptop 32Giga RAM", "ImageFile": "ImageFileb2", "Price": 240 }])




 db.Products.find({}).pretty()
 
 
 

docker run -d -p 8081:8081 --name mongoGUI mongo-express
docker run -it --rm -p 8081:8081 --name mongoGUI mongo-express
--
 docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d
 docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up --build
 docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down

 docker container run --d --p 8080:80 --name mvcapp webapplication1:dev
 
 docker run --name some-postgres -e POSTGRES_PASSWORD=openpgpwd -d postgres
 
 
 docker run -d -p 6379:6379 --name shopping-redis redis
 docker exec -it shopping-redis /bin/bash
 
 
 portainer
 username:admin
 pass:admin123admin
 http://localhost:9000/#!/2/docker/containers
 
 
 postgres
 http://localhost:5050/browser/
 
   
   
 SqlServer ______________________________________________________________________
 
 docker run -d -p 1433:1434 --name orderdb mcr.microsoft.com/mssql/server:2017-latest
 
 
 Rabbitmq ______________________________________________________________________
 docker run -d --hostname my-rabbit --name some-rabbit -p 8015:15672 rabbitmq
 docker run -d -p 27017:27017 --name ShoppingDB mongo
