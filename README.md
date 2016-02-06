# Learning-WCF
Just a little project which should help me with .net WCF learning.

# Basics of WFC for .net 3.5 Samples

## Chapter 1

### Sample 1

Server - Code 
Client - Code.

### Sample 2

Server - app config 

### Sample 3

Extend Sample 1 with MEX(Metadata Exchange) endpoing 

### Sample 4

Extend Sample 2 with MEX(Metadata Exchange) endpoing 

## Chapter 2

### Sample 1

Synchronous Request-Reply

Server - Code 
Client - Code

### Sample 2

Asynchronous Request-Reply

Server - app config 
Client - proxy generator

### Sample 3

One way Operation

Server - app config 
Client - proxy generator

### Sample 4

Duplex Operation

Server - app config 
Client - proxy generator
Used TCP binding because Dual HTTP binding doesn't want to work on local machine for both server and client simultaneously.

### Sample 5

Data contracts

Server - app config 
Client - proxy generator
Use [KnownType] attribute to specify derived types for WCF framework


### Sample 6

Data contracts

Server - app config 
Client - proxy generator
Use config file to specify derived types for WCF framework


### Sample 7

Collection Data contracts

Server - app config 
Client - proxy generator

### Sample 8

Message contract

Server - app config 
Client - proxy generator

## Chapter 5

### Sample 1

Behaviors 
InstanceContextMode = InstanceContextMode.PerSession
ConcurrencyMode = ConcurrencyMode.Single

### Sample 2

Behaviors 
InstanceContextMode = InstanceContextMode.Single
ConcurrencyMode = ConcurrencyMode.Multiple

### Sample 3

Behaviors 
InstanceContextMode = InstanceContextMode.Single
ConcurrencyMode = ConcurrencyMode.Single

### Sample 4

Behaviors 
InstanceContextMode = InstanceContextMode.PerSession
ConcurrencyMode = ConcurrencyMode.Multiple

### Sample 5

Behaviors - Transaction
InstanceContextMode = InstanceContextMode.PerSession
ConcurrencyMode = ConcurrencyMode.Single
Also TransactionalCollection is implemented to show transaction work more deeply.

### Sample 6

Custom Service Behavior using config file.

### Sample 7

Streamed type to send serialized data contract

## Chapter 8

### Sample 1

**Security. X.509 certificates + SSL**

Generate Server and Client certificate
```makecert.exe -n "CN=RootCATest" -r -sv C:\RootCATest.pvk C:\RootCATest.cer```

Add RootCATest certificate to a Client and Server machines to "Trusted Root Certification Authorities"

On a server machine generate server cetificate
```makecert -sk MyServer C:\RootCATest.cer -sr localmachine -ss my -sky exchange -pe```

Bind server certificate on the Server
```netsh http add sslcert ipport=0.0.0.0:8002 certhash=<FIND IT> appid="{5ee247fe-720c-469c-834a-66dde49bcdf2}"```

Run the Server and the Client 

[Brief article](https://msdn.microsoft.com/en-us/library/ff648498.aspx?f=255&MSPPError=-2147217396)

# Projects

## Chat

Just a stupid client server chat