# SQLite簡易データ抽出ツール

## 概要

SQLite簡易データ抽出ツールはSQLiteのデータベースから
クエリの知識が無い人でも簡単に抽出条件を設定し、データ抽出を行う
為のアプリケーションです。

## 機能紹介

### 共通
戻る⇒クリック後、前の画面を遷移する。
終了⇒クリック後、アプリケーションを終了します。

###　ログイン
システム初期画面です。

ログイン⇒クリック後、認証情報が正しければ、表選択画面へ遷移します。
接続変更⇒クリック後、データベースの接続情報変更画面へ遷移します。

###　データベース接続情報変更
データベースの接続情報を変更する画面です。

下記の項目の内容を入力して下さい。
・データベースのファイルのパス

変更⇒クリック後、認証情報が正しければ、データベースの接続情報を変更します。

###　表選択
データベースから抽出対象となる表を選択する画面です。

一覧から対象の表をクリックします。

選択⇒クリック後、抽出条件設定画面へ遷移します。

###　抽出条件設定
選択された表から抽出条件を設定する画面です。

設定⇒クリック後、データ出力結果画面へ遷移します。

###　データ出力結果
設定された条件から抽出した結果を表示する画面です。

出力⇒クリック後、　ファイル出力画面へ遷移します。

###　ファイル出力
出力結果からファイルを出力しました。

出力⇒クリック後、データ抽出結果をファイル出力が実行されます。

