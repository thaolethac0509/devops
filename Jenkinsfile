pipeline {
    agent any
    environment {
        COMPOSE_PROJECT_NAME = "Devops"
    }
    stages {
        stage('Checkout Source Code') {
            steps {
                git url: 'https://github.com/thaolethac0509/devops.git', branch: 'master'
            }
        }
        stage('Stop Current Containers') {
            steps {
                sh 'docker compose down || true'
            }
        }
        stage('Build & Start Docker Compose') {
            steps {
                sh 'docker compose up -d --build'
            }
        }
        stage('List Running Containers') {
            steps {
                sh 'docker ps'
            }
        }
    }
}
