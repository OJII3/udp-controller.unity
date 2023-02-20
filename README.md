# udp controller

UDP通信でロボットを動かすためのiOSアプリケーションをUnityで作る。

- 当面のところ、一方的に送り、netcatなどで適当なUDPサーバーで受け取る。
- 必要になれば、サーバーサイドで受信データの管理などを行う。
  - ROSでやることになった

## 環境

OS: Windows11
Unity Editor: 2021.3.16f1

## 概要

### シーン
- TestConnection
  - IP, Port を指定して接続、テキストを送信できる
- MainController(未完成)
  - InputActionsでジョイスティックなどを読む
  - 操作画面とメニュー画面を作る
  - 作りながら色々すり合わせる必要がありそう

## UDP通信の確認

受信側

```shell
hostname -I #IPアドレスを確認してメモ
```

```shell
nc -lu <port> #8887ポートを開く
```

送信側

```shell
nc -u <IPアドレス> <port>
```

## TestConnection

受信側のシェルにてIPアドレスを確認し、メモ

```shell
hostname -I
```

続いてUDPサーバーを立てる

```shell
nc -lu 8887 #適当なポートを開く
```

送信側にてUnityのTestConnectionシーンを開き、プレイ。

先ほどのIPアドレスとポートを入力し、`Connect`。テキストを入力して`Submit`

