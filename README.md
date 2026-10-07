# C# Design Patterns

A practical C# repository for learning and practicing **Gang of Four (GoF) Design Patterns**, with a focus on understanding when to use a pattern, recognizing it in real-world scenarios, and implementing a small working example.

This repository was created as part of my preparation for software architecture and AI-focused engineering interviews. The goal is **not to memorize pattern code**, but to understand the problem each pattern solves and be able to reconstruct the implementation when needed.

## 🎯 Learning Goals

- Understand the intent behind each design pattern.
- Recognize design-pattern scenarios in interviews and real projects.
- Implement patterns using modern C#.
- Understand relationships and differences between similar patterns.
- Connect patterns with SOLID principles.
- Build confidence in explaining design decisions and trade-offs.

## 📚 Patterns Covered

### Creational

| Pattern | Status |
|---|---|
| Factory Method | ✅ Implemented |
| Abstract Factory | ⏳ Planned |
| Builder | ✅ Implemented |
| Prototype | ✅ Implemented |
| Singleton | ✅ Implemented |

### Structural

| Pattern | Status |
|---|---|
| Adapter | ✅ Implemented |
| Bridge | ✅ Implemented |
| Composite | ✅ Implemented |
| Decorator | ✅ Implemented |
| Facade | ✅ Implemented |
| Flyweight | ✅ Implemented |
| Proxy | ✅ Implemented |

### Behavioral

| Pattern | Status |
|---|---|
| Chain of Responsibility | ✅ Implemented |
| Command | ✅ Implemented |
| Iterator | ✅ Implemented |
| Mediator | ✅ Implemented |
| Memento | ✅ Implemented |
| Observer | ✅ Implemented |
| State | ✅ Implemented |
| Strategy | ✅ Implemented |
| Template Method | ✅ Implemented |

## ⭐ Pattern Priority / Interview Focus

The following priority reflects my learning and interview-preparation focus.

| Category | Pattern | Priority for You |
|---|---|---|
| Creational | Factory Method | ⭐⭐⭐⭐⭐ Must know |
| Creational | Abstract Factory | ⭐⭐⭐ Should know |
| Creational | Builder | ⭐⭐⭐⭐⭐ Must know |
| Creational | Prototype | ⭐⭐ Awareness |
| Creational | Singleton | ⭐⭐⭐⭐ Know well, including drawbacks |
| Structural | Adapter | ⭐⭐⭐⭐⭐ Must know |
| Structural | Bridge | ⭐⭐ Awareness |
| Structural | Composite | ⭐⭐⭐ Should know |
| Structural | Decorator | ⭐⭐⭐⭐⭐ Must know |
| Structural | Facade | ⭐⭐⭐⭐⭐ Must know |
| Structural | Flyweight | ⭐⭐ Awareness |
| Structural | Proxy | ⭐⭐⭐⭐ Know |
| Behavioral | Chain of Responsibility | ⭐⭐⭐⭐ Know |
| Behavioral | Command | ⭐⭐⭐⭐ Know |
| Behavioral | Iterator | ⭐⭐⭐ Basic/awareness |
| Behavioral | Mediator | ⭐⭐⭐⭐ Know |
| Behavioral | Memento | ⭐⭐ Awareness |
| Behavioral | Observer | ⭐⭐⭐⭐⭐ Must know |
| Behavioral | State | ⭐⭐⭐⭐ Know |
| Behavioral | Strategy | ⭐⭐⭐⭐⭐ Must know |
| Behavioral | Template Method | ⭐⭐⭐⭐ Know |

> **Note:** "Priority for you" reflects interview and practical-learning priority, not the general importance of a pattern in software engineering.

## 🧠 Quick Mental Map

A simple way to remember the three categories:

```text
Creational → CREATE objects
Structural → CONNECT / COMPOSE objects
Behavioral  → COMMUNICATE / CONTROL behavior
```

### Important Recognition Shortcuts

```text
Factory Method     → Let creators decide which product to create
Abstract Factory   → Create a family of related products
Builder            → Build a complex object step-by-step
Prototype          → Clone an existing object
Singleton          → One shared instance within a defined scope

Adapter            → Make incompatible interfaces work together
Bridge             → Separate independent dimensions
Composite          → Treat individual and group uniformly
Decorator          → Add behavior without changing the interface
Facade             → Hide subsystem complexity behind a simple interface
Flyweight          → Share common data to reduce memory
Proxy              → Control access to another object

Chain              → Pass request through handlers
Command            → Encapsulate an action/request as an object
Iterator            → Traverse a collection without exposing its structure
Mediator           → Centralize communication between objects
Memento            → Save and restore object state
Observer           → Notify multiple subscribers
State              → Change behavior based on current state
Strategy            → Choose interchangeable behavior/algorithm
Template Method    → Fixed algorithm + customizable steps
```

## ⚖️ Important Pattern Comparisons

### Factory Method vs Abstract Factory

- **Factory Method:** creates one type of product through a factory method.
- **Abstract Factory:** creates a family of related products.

### Adapter vs Decorator

- **Adapter:** solves an interface incompatibility.
- **Decorator:** adds behavior while keeping the same interface.

### Facade vs Mediator

- **Facade:** simplifies access to a complex subsystem.
- **Mediator:** coordinates communication between peer objects.

### State vs Strategy

- **State:** behavior changes because the object's internal state changes.
- **Strategy:** behavior changes because the application chooses a different algorithm/strategy.

### Strategy vs Template Method

- **Strategy:** composition; swap the algorithm/behavior.
- **Template Method:** inheritance; keep the algorithm skeleton fixed and customize selected steps.

## 📂 Repository Structure

Each pattern is maintained as a small, independent .NET console project so that the implementation can be studied and executed in isolation.

```text
DesignPatterns/
├── Creational/
│   ├── FactoryMethod/
│   ├── Builder/
│   ├── Prototype/
│   └── Singleton/
│
├── Structural/
│   ├── Adapter/
│   ├── Bridge/
│   ├── Composite/
│   ├── Decorator/
│   ├── Facade/
│   ├── Flyweight/
│   └── Proxy/
│
└── Behavioral/
    ├── ChainOfResponsibility/
    ├── Command/
    ├── Iterator/
    ├── Mediator/
    ├── Memento/
    ├── Observer/
    ├── State/
    ├── Strategy/
    └── TemplateMethod/
```

## 💻 Technology

- **C#**
- **.NET 10**
- Console applications
- Object-Oriented Programming
- SOLID principles
- Gang of Four Design Patterns

## 🚀 Running an Example

Navigate to any pattern directory and run its project.

For example:

```bash
cd Behavioral/State
dotnet run
```

Another example:

```bash
cd Behavioral/Strategy
dotnet run
```

Each example is intentionally small so the pattern structure and relationships are easy to identify.

## 🧩 Learning Approach

For each pattern, the focus is on:

1. **Problem** — What problem does the pattern solve?
2. **Core idea** — What is the simplest way to explain it?
3. **Recognition clues** — How can I identify it in an interview or project?
4. **Structure** — What are the key classes/interfaces and relationships?
5. **C# implementation** — How can the pattern be implemented cleanly?
6. **Trade-offs** — When should and shouldn't it be used?
7. **Similar patterns** — How is it different from patterns that look similar?

The implementation is kept intentionally small. The objective is to understand the **design intent and relationships**, rather than memorize boilerplate code.

## 📌 Current Progress

### Creational

- [x] Factory Method
- [ ] Abstract Factory
- [x] Builder
- [x] Prototype
- [x] Singleton

### Structural

- [x] Adapter
- [x] Bridge
- [x] Composite
- [x] Decorator
- [x] Facade
- [x] Flyweight
- [x] Proxy

### Behavioral

- [x] Chain of Responsibility
- [x] Command
- [x] Iterator
- [x] Mediator
- [x] Memento
- [x] Observer
- [x] State
- [x] Strategy
- [x] Template Method

## 🎯 Interview Preparation Focus

The next stage after completing the patterns is **retrieval and reconstruction practice** rather than repeatedly reading the implementations.

The intended interview process is:

```text
Scenario
   ↓
Identify the problem
   ↓
Select the pattern
   ↓
Explain why
   ↓
Draw the structure
   ↓
Write the minimal C# skeleton
   ↓
Discuss trade-offs
```

This approach emphasizes practical design thinking over memorization.

## 📖 References

- Gang of Four — *Design Patterns: Elements of Reusable Object-Oriented Software*
- Microsoft C# / .NET documentation

## 👤 Author

**Dev Sharma**

Software Developer | .NET | Azure | GenAI | AI Architecture

This repository is part of my ongoing journey toward **AI Architecture and enterprise AI system design**.
