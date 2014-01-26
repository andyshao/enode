﻿using ECommon.Logging;
using ECommon.Retring;
using ENode.Domain;
using ENode.Eventing;
using ENode.Infrastructure.Logging;

namespace ENode.Commanding.Impl
{
    /// <summary>The default implementation of IWaitingCommandMessageHandler.
    /// </summary>
    public class DefaultWaitingCommandMessageHandler : DefaultCommandMessageHandler, IWaitingCommandMessageHandler
    {
        #region Constructors

        /// <summary>Parameterized constructor.
        /// </summary>
        /// <param name="waitingCommandCache"></param>
        /// <param name="processingCommandCache"></param>
        /// <param name="commandHandlerProvider"></param>
        /// <param name="aggregateRootTypeProvider"></param>
        /// <param name="eventSender"></param>
        /// <param name="eventPublisher"></param>
        /// <param name="actionExecutionService"></param>
        /// <param name="commandContext"></param>
        /// <param name="loggerFactory"></param>
        public DefaultWaitingCommandMessageHandler(
            IWaitingCommandCache waitingCommandCache,
            IProcessingCommandCache processingCommandCache,
            ICommandHandlerProvider commandHandlerProvider,
            IAggregateRootTypeProvider aggregateRootTypeProvider,
            IEventPublisher committedEventSender,
            IActionExecutionService actionExecutionService,
            ICommandContext commandContext,
            ILoggerFactory loggerFactory)
            : base(waitingCommandCache,
                processingCommandCache,
                commandHandlerProvider,
                aggregateRootTypeProvider,
                committedEventSender,
                actionExecutionService,
                commandContext,
                loggerFactory)
        {
        }

        #endregion

        /// <summary>Check whether the command is added to the waiting command cache.
        /// Override the base method, and always returns false.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected override bool CheckWaitingCommand(ICommand command)
        {
            return false;
        }
    }
}