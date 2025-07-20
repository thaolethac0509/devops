pipeline {
    agent any

    environment {
        COMPOSE_PROJECT_NAME = "devopsnews"
    }

    stages {
        stage('Checkout Source Code') {
            steps {
                git url: 'https://github.com/thaolethac0509/devops.git', branch: 'master'
            }
        }

        stage('Stop Current Containers') {
            steps {
                script {
                    bat '''
                        echo Stopping containers...
                        docker-compose down || exit 0
                    '''
                }
            }
        }

        stage('Build & Start Docker Compose') {
            steps {
                script {
                    bat '''
                        echo Building and starting containers...
                        docker-compose up -d --build
                    '''
                }
            }
        }

        stage('List Running Containers') {
            steps {
                script {
                    bat '''
                        echo Listing running containers...
                        docker ps
                    '''
                }
            }
        }
    }
}
