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

# Projects

## Chat

Just a stupid client server chat