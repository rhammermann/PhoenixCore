Write-Output "Stopping complete_rabbit"
docker container stop complete_rabbit
Write-Output "Removing complete_rabbit"
docker rm complete_rabbit
Write-Output "Starting complete_rabbit ...."
docker run -d --name=complete_rabbit rabbitmq:latest; echo $?
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' complete_rabbit
