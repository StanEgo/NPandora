﻿namespace Codesophy.Process
{
    /// <summary>
    /// This interface is responsible for being a fundamental "atom" of the application.
    /// </summary>
    /// 
    /// <typeparam name="TWhen">
    /// Structure of the information that is provided to the feature.
    /// </typeparam>
    /// <typeparam name="TThen">
    /// Structure of the result we expect from the future.
    /// </typeparam>
    /// <remarks>
    /// <para>
    /// If we purify some application's feature from its representation (e.g. UI input/output),
    /// then it becomes a clean concept where we have some <typeparamref name="TWhen"/> as
    /// input and expects <typeparamref name="TThen"/> from the feature.
    /// </para>
    /// 
    /// <para>
    /// Such design was based on some 
    /// </para>
    /// 
    /// <para>
    /// Such atomic concept has several advantages. The first is its atomicity (SRP) to have
    /// the SOLID design.
    /// </para>
    /// 
    /// <para>
    /// Compared to another "atom" like function it may have another services injected
    /// by IoC-container for example. Also it has not so strict signature as functions
    /// have. For example, the same object instance may be processed by different
    /// <see cref="IProcess{TWhen, TThen}">features</see> that will use only some
    /// part (polymorphic) or interface from this instance.
    /// </para>
    /// 
    /// <para>
    /// The idea of the feature also coupled with BDD and its Given-When-Then pattern.
    /// </para>
    /// 
    /// TODO:Should it be IProcess?
    /// </remarks>
    public interface IProcess<in TWhen, out TThen>
    {
        /// <summary>
        /// Produce the feature results for the <paramref name="when"/> input.
        /// </summary>
        /// <param name="when">
        /// Feature's input.
        /// </param>
        /// <returns>
        /// Result, expected from the feature.
        /// </returns>
        TThen When(TWhen when);
    }
}
