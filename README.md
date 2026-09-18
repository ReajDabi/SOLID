## SOLID Project
2.
## Single Responsibility Principle (SRP)

The original Form1 class had too many responsibilities.So I separated
the responsibilities into different classes such as OrderCalculator,
DiscountService, SqlOrderRepository, EmailService, and InvoicePrinter.
Now each class has a more focused responsibility.

## Open/Closed Principle (OCP)

The original discount code used multiple if/else statements for each
discount type. I replaced this with IDiscountStrategy and separate
discount classes such as StudentDiscount, SeniorDiscount, and
BlackFridayDiscount. New discount strategies can be added without
changing the existing discount calculation code ((so its open for adding new type but close for modification).

## Liskov Substitution Principle (LSP)

Discount implementations must follow the IDiscountStrategy contract.
A class implementing the interface should be usable wherever an
IDiscountStrategy is expected. A class that cannot safely perform the
required operation violates this substitutability rule( also cause errors).

## Interface Segregation Principle (ISP)

Instead of creating one large interface containing unrelated operations,
the project uses smaller interfaces such as IOrderRepository,
IEmailService, IInvoicePrinter, and IDiscountStrategy. Classes only
need to depend on the operations that are relevant to them.

## Dependency Inversion Principle (DIP)

Form1 no longer directly handles database, email, and printing
implementation details. It depends on interfaces such as
IOrderRepository, IEmailService, and IInvoicePrinter. The concrete
classes provide the actual implementations.






3.
  This breaks the substitutability promise because FreeShippingDiscount
implements IDiscountStrategy, but it cannot actually perform the operation
required by the interface. If the program expects any IDiscountStrategy
to calculate a discount, replacing another discount with
FreeShippingDiscount causes the program to throw a
NotSupportedException.

Liskov Substitution Principle says that objects of a subtype should be
usable wherever objects of the base type or interface are expected
without breaking the expected behavior of the program. A subtype that
cannot safely perform the operations promised by its interface should
not implement that interface.

4.
FakeOrderRepository.cs let me test my code or the application
without actually connecting to a SQL Server.


