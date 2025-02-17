using MediatR;

namespace BuildingBlocks.CQRS;

// This interface defines a command handler for commands that do not return a response (Unit represents void).
public interface ICommandHandler<in TCommand>
    : ICommandHandler<TCommand, Unit>
    where TCommand : ICommand<Unit>
{
}

// This interface defines a command handler that processes a command (TCommand) and returns a response (TResponse).
public interface ICommandHandler<in TCommand, TResponse> 
    : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
{
}
