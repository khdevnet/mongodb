```
docker run --network transaction-2pc_default -e ME_CONFIG_MONGODB_SERVER=transaction-2pc_mongo_1 -p 8081:8081 mongo-express
docker run --network transaction-2pc_default -p 8081:8080 adminer
docker-compose rm -fv mongo
```