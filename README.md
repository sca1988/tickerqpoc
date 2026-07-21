POC to test TickerQ
az login --tenant xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
az acr login --name <acr_name>


docker build -t webapplication-tickerq:latest .
docker tag webapplication-tickerq:latest xxxxx.azurecr.io/webapplication-tickerq:latest
docker push xxxx.azurecr.io/webapplication-tickerq:latest 