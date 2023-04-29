# udp controller

UDP 通信でロボットを動かすための iOS アプリケーションを Unity で作る。

- 当面のところ、一方的に送り、netcat などで適当な UDP サーバーで受け取る。
  - Unity 側でも、ROS 側からの UDP 通信を受け取るようにすることになった。
- ~~必要になれば、サーバーサイドで受信データの管理などを行う。~~
  - ROS で機体側の送受信をすることになった
  - 別リポジトリで、ROS での UDP 通信を行うプログラムを作成した。

## 環境

OS: Ubuntu 22.04
Unity Editor: 2021.3.22f1
Gamepad: PS4

## 概要

### 一台でテストする

- Unity のデバッグは、Unity のエディター上で行う。

1. ターミナルで、`hostname -I` で IP アドレスを確認する。
2. ターミナルで、`nc -ul 8888` で UDP サーバーを起動する。
3. Unity で、`Ctrl + P` でプレイモードにする。
4. 先ほどの IP アドレスを入力して、`Connect` ボタンを押す。
5. 画面上のボタンを押すか、ゲームパッドを操作すると、ターミナルに送信される。(自分自身に送っているので、Unity 上のログにも出力される)
6. ターミナルで、`Ctrl + C` で UDP サーバーを終了し、`nc -u <IP アドレス> 8888` で送信用に UDP クライアントを起動する。`
7. ターミナルにテキストを入力すると、Unity 上のログに出力される。

### 複数台でテストする

上記を複数台で行う。

## 送信するテキスト

- プレコンの入力

```csharp
if (_customActions.UI.LeftStickDown.inProgress) NetworkManager.Send("LeftStickDown");
if (_customActions.UI.LeftStickUp.inProgress) NetworkManager.Send("LeftStickUp");
if (_customActions.UI.LeftStickLeft.inProgress) NetworkManager.Send("LeftStickLeft");
if (_customActions.UI.LeftStickRight.inProgress) NetworkManager.Send("LeftStickRight");
if (_customActions.UI.LeftStickPress.inProgress) NetworkManager.Send("LeftStickPress");
if (_customActions.UI.RightStickDown.inProgress) NetworkManager.Send("RightStickDown");
if (_customActions.UI.RightStickUp.inProgress) NetworkManager.Send("RightStickUp");
if (_customActions.UI.RightStickLeft.inProgress) NetworkManager.Send("RightStickLeft");
if (_customActions.UI.RightStickRight.inProgress) NetworkManager.Send("RightStickRight");
if (_customActions.UI.RightStickPress.inProgress) NetworkManager.Send("RightStickPress");
if (_customActions.UI.DPadDown.inProgress) NetworkManager.Send("DPadDown");
if (_customActions.UI.DPadUp.inProgress) NetworkManager.Send("DPadUp");
if (_customActions.UI.DPadLeft.inProgress) NetworkManager.Send("DPadLeft");
if (_customActions.UI.DPadRight.inProgress) NetworkManager.Send("DPadRight");
if (_customActions.UI.L1.inProgress) NetworkManager.Send("L1");
if (_customActions.UI.L2.inProgress) NetworkManager.Send("L2");
if (_customActions.UI.R1.inProgress) NetworkManager.Send("R1");
if (_customActions.UI.R2.inProgress) NetworkManager.Send("R2");
if (_customActions.UI.Triangle.inProgress) NetworkManager.Send("Triangle");
if (_customActions.UI.Circle.inProgress) NetworkManager.Send("Circle");
if (_customActions.UI.Cross.inProgress) NetworkManager.Send("Cross");
if (_customActions.UI.Square.inProgress) NetworkManager.Send("Square");
if (_customActions.UI.Select.inProgress) NetworkManager.Send("Select");
if (_customActions.UI.Start.inProgress) NetworkManager.Send("Start");
```
