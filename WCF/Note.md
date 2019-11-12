<!-- TOC -->

- [WCF服务通信的三种模式](#wcf%e6%9c%8d%e5%8a%a1%e9%80%9a%e4%bf%a1%e7%9a%84%e4%b8%89%e7%a7%8d%e6%a8%a1%e5%bc%8f)
  - [请求/应答](#%e8%af%b7%e6%b1%82%e5%ba%94%e7%ad%94)
  - [单项操作](#%e5%8d%95%e9%a1%b9%e6%93%8d%e4%bd%9c)
  - [回调操作](#%e5%9b%9e%e8%b0%83%e6%93%8d%e4%bd%9c)
    - [Contract](#contract)
    - [Service](#service)
    - [Client](#client)
  - [流操作](#%e6%b5%81%e6%93%8d%e4%bd%9c)

<!-- /TOC -->
# WCF服务通信的三种模式
## 请求/应答
## 单项操作
## 回调操作
### Contract
  ```C#
  using System.ServiceModel;
  
  namespace Demo.WCF.Callback
  {
    #region Service contract
    [ServiceContract(Namespace = "http://xingyafei.me")]
    public interface ICalculator
    {
        [OperationContract]
        void Add(double a, double b);
    }
    #endregion
    
    #region Callback contract
    public interface ICallback
    {
        void GetResult(double result, dobule a, double b);
    }
    #endregion
  }
  
  
  ```
### Service
### Client
## 流操作