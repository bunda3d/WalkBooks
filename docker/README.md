# Docker compose and multi-container configs


## Local Docker Development

### Build API container
docker build -t walkbooks-api:local -f src/Api/Dockerfile .

### Run API container
docker run --rm -p 5000:80 walkbooks-api:local

### Stop container
Ctrl + C

### View images
docker images

### Remove image
docker rmi walkbooks-api:local
