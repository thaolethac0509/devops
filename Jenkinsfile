pipeline {
    agent any

    triggers {
        // Tự động build khi có push từ GitHub webhook
        githubPush()
    }

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
                        echo Stopping containers if exist...
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

    post {
        always {
            echo "Pipeline finished!"
        }
        failure {
            echo "Build failed!"
        }
        success {
            echo "Build succeeded!"
        }
    }
}
