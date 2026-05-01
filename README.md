<div align="center">
<h1>SignSniper Server</h1>

实现动态二维码传输的服务端
</div>

## 部署
### 使用 Docker 部署
#### 1. 从 Releases 下载 Docker 镜像
下载与服务器架构相同的服务端。
#### 2. 导入 Docker 镜像并运行 Docker 容器
```bash
docker load --input xxx.tar.gz  # 将 xxx 替换为真实的文件名，如 signsniper-docker-arm64
docker run -d --name signsniper --restart unless-stopped -p 2350:2350 signsniper-server:latest
```
服务端端口默认为 2350。
