using System;
using System.Linq;
using System.Text;
using LivingDocumentation.Uml;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PlantUml.Builder.SequenceDiagrams;
using SequenceDiagramCSharpSyntaxWalker.Extensions;

namespace SequenceDiagramCSharpSyntaxWalker.SyntaxWalkers
{
    public class SequenceWalker : CSharpSyntaxWalker
    {
        private StringBuilder _walkerLog = new StringBuilder();

        public SequenceWalker(SyntaxTree tree, CSharpCompilation compilation)
        {
            this.RootSyntaxTree = tree;
            this.Root = this.RootSyntaxTree.GetRoot();
            this.Compilation = compilation;
            this.Model = compilation.GetSemanticModel(this.RootSyntaxTree, false);

            this._walkerLog.UmlDiagramStart("myFile.uml");
            this._walkerLog.AppendLine(
                @"!theme vibrant from https://raw.githubusercontent.com/plantuml/plantuml/master/themes");
            this._walkerLog.SkinParameter(SkinParameter.ResponseMessageBelowArrow, true.ToString());
            this._walkerLog.AutoActivate();
            this._walkerLog.AutoNumber();
        }

        public CSharpCompilation Compilation { get; }

        public MetadataReference MetaData { get; }

        public SyntaxTree RootSyntaxTree { get; }

        public SemanticModel Model { get; }

        public SyntaxNode Root { get; set; }

        public override void DefaultVisit(SyntaxNode node)
        {
            base.DefaultVisit(node);
        }

        public override void Visit(SyntaxNode node)
        {
            base.Visit(node);
        }

        public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)
        {
            base.VisitAccessorDeclaration(node);
        }

        public override void VisitAccessorList(AccessorListSyntax node)
        {
            base.VisitAccessorList(node);
        }

        public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
        {
            base.VisitAliasQualifiedName(node);
        }

        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            base.VisitAnonymousMethodExpression(node);
        }

        public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
        {
            base.VisitAnonymousObjectCreationExpression(node);
        }

        public override void VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
        {
            base.VisitAnonymousObjectMemberDeclarator(node);
        }

        public override void VisitArgument(ArgumentSyntax node)
        {
            base.VisitArgument(node);
        }

        public override void VisitArgumentList(ArgumentListSyntax node)
        {
            base.VisitArgumentList(node);
        }

        public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
        {
            base.VisitArrayCreationExpression(node);
        }

        public override void VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
        {
            base.VisitArrayRankSpecifier(node);
        }

        public override void VisitArrayType(ArrayTypeSyntax node)
        {
            base.VisitArrayType(node);
        }

        public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
        {
            base.VisitArrowExpressionClause(node);
        }

        public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            base.VisitAssignmentExpression(node);
        }

        public override void VisitAttribute(AttributeSyntax node)
        {
            base.VisitAttribute(node);
        }

        public override void VisitAttributeArgument(AttributeArgumentSyntax node)
        {
            base.VisitAttributeArgument(node);
        }

        public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node)
        {
            base.VisitAttributeArgumentList(node);
        }

        public override void VisitAttributeList(AttributeListSyntax node)
        {
            base.VisitAttributeList(node);
        }

        public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
        {
            base.VisitAttributeTargetSpecifier(node);
        }

        public override void VisitAwaitExpression(AwaitExpressionSyntax node)
        {
            base.VisitAwaitExpression(node);
        }

        public override void VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node)
        {
            base.VisitBadDirectiveTrivia(node);
        }

        public override void VisitBaseExpression(BaseExpressionSyntax node)
        {
            base.VisitBaseExpression(node);
        }

        public override void VisitBaseList(BaseListSyntax node)
        {
            base.VisitBaseList(node);
        }

        public override void VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            base.VisitBinaryExpression(node);
        }

        public override void VisitBinaryPattern(BinaryPatternSyntax node)
        {
            base.VisitBinaryPattern(node);
        }

        public override void VisitBlock(BlockSyntax node)
        {
            base.VisitBlock(node);
        }

        public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node)
        {
            base.VisitBracketedArgumentList(node);
        }

        public override void VisitBracketedParameterList(BracketedParameterListSyntax node)
        {
            base.VisitBracketedParameterList(node);
        }

        public override void VisitBreakStatement(BreakStatementSyntax node)
        {
            base.VisitBreakStatement(node);
        }

        public override void VisitCasePatternSwitchLabel(CasePatternSwitchLabelSyntax node)
        {
            base.VisitCasePatternSwitchLabel(node);
        }

        public override void VisitCaseSwitchLabel(CaseSwitchLabelSyntax node)
        {
            base.VisitCaseSwitchLabel(node);
        }

        public override void VisitCastExpression(CastExpressionSyntax node)
        {
            base.VisitCastExpression(node);
        }

        public override void VisitCatchClause(CatchClauseSyntax node)
        {
            base.VisitCatchClause(node);
        }

        public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
        {
            base.VisitCatchDeclaration(node);
        }

        public override void VisitCatchFilterClause(CatchFilterClauseSyntax node)
        {
            base.VisitCatchFilterClause(node);
        }

        public override void VisitCheckedExpression(CheckedExpressionSyntax node)
        {
            base.VisitCheckedExpression(node);
        }

        public override void VisitCheckedStatement(CheckedStatementSyntax node)
        {
            base.VisitCheckedStatement(node);
        }

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            base.VisitClassDeclaration(node);
        }

        public override void VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
        {
            base.VisitClassOrStructConstraint(node);
        }

        public override void VisitCompilationUnit(CompilationUnitSyntax node)
        {
            base.VisitCompilationUnit(node);
        }

        public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
        {
            base.VisitConditionalAccessExpression(node);
        }

        public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
        {
            base.VisitConditionalExpression(node);
        }

        public override void VisitConstantPattern(ConstantPatternSyntax node)
        {
            base.VisitConstantPattern(node);
        }

        public override void VisitConstructorConstraint(ConstructorConstraintSyntax node)
        {
            base.VisitConstructorConstraint(node);
        }

        public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            base.VisitConstructorDeclaration(node);
        }

        public override void VisitConstructorInitializer(ConstructorInitializerSyntax node)
        {
            base.VisitConstructorInitializer(node);
        }

        public override void VisitContinueStatement(ContinueStatementSyntax node)
        {
            base.VisitContinueStatement(node);
        }

        public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
        {
            base.VisitConversionOperatorDeclaration(node);
        }

        public override void VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax node)
        {
            base.VisitConversionOperatorMemberCref(node);
        }

        public override void VisitCrefBracketedParameterList(CrefBracketedParameterListSyntax node)
        {
            base.VisitCrefBracketedParameterList(node);
        }

        public override void VisitCrefParameter(CrefParameterSyntax node)
        {
            base.VisitCrefParameter(node);
        }

        public override void VisitCrefParameterList(CrefParameterListSyntax node)
        {
            base.VisitCrefParameterList(node);
        }

        public override void VisitDeclarationExpression(DeclarationExpressionSyntax node)
        {
            base.VisitDeclarationExpression(node);
        }

        public override void VisitDeclarationPattern(DeclarationPatternSyntax node)
        {
            base.VisitDeclarationPattern(node);
        }

        public override void VisitDefaultConstraint(DefaultConstraintSyntax node)
        {
            base.VisitDefaultConstraint(node);
        }

        public override void VisitDefaultExpression(DefaultExpressionSyntax node)
        {
            base.VisitDefaultExpression(node);
        }

        public override void VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node)
        {
            base.VisitDefaultSwitchLabel(node);
        }

        public override void VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node)
        {
            base.VisitDefineDirectiveTrivia(node);
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            base.VisitDelegateDeclaration(node);
        }

        public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
        {
            base.VisitDestructorDeclaration(node);
        }

        public override void VisitDiscardDesignation(DiscardDesignationSyntax node)
        {
            base.VisitDiscardDesignation(node);
        }

        public override void VisitDiscardPattern(DiscardPatternSyntax node)
        {
            base.VisitDiscardPattern(node);
        }

        public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
        {
            base.VisitDocumentationCommentTrivia(node);
        }

        public override void VisitDoStatement(DoStatementSyntax node)
        {
            base.VisitDoStatement(node);
        }

        public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
        {
            base.VisitElementAccessExpression(node);
        }

        public override void VisitElementBindingExpression(ElementBindingExpressionSyntax node)
        {
            base.VisitElementBindingExpression(node);
        }

        public override void VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node)
        {
            base.VisitElifDirectiveTrivia(node);
        }

        public override void VisitElseClause(ElseClauseSyntax node)
        {
            string ifStatement = ((IfStatementSyntax)node.Statement).Condition.ToString();
            LivingDocumentation.Uml.StringBuilderExtensions.ElseStart(this._walkerLog, ifStatement);
            base.VisitElseClause(node);
        }

        public override void VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node)
        {
            base.VisitElseDirectiveTrivia(node);
        }

        public override void VisitEmptyStatement(EmptyStatementSyntax node)
        {
            base.VisitEmptyStatement(node);
        }

        public override void VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
        {
            base.VisitEndIfDirectiveTrivia(node);
        }

        public override void VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
        {
            base.VisitEndRegionDirectiveTrivia(node);
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            base.VisitEnumDeclaration(node);
        }

        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            base.VisitEnumMemberDeclaration(node);
        }

        public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
        {
            base.VisitEqualsValueClause(node);
        }

        public override void VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node)
        {
            base.VisitErrorDirectiveTrivia(node);
        }

        public override void VisitEventDeclaration(EventDeclarationSyntax node)
        {
            base.VisitEventDeclaration(node);
        }

        public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
        {
            base.VisitEventFieldDeclaration(node);
        }

        public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
        {
            base.VisitExplicitInterfaceSpecifier(node);
        }

        public override void VisitExpressionColon(ExpressionColonSyntax node)
        {
            base.VisitExpressionColon(node);
        }

        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            base.VisitExpressionStatement(node);
        }

        public override void VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
        {
            base.VisitExternAliasDirective(node);
        }

        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            base.VisitFieldDeclaration(node);
        }

        public override void VisitFileScopedNamespaceDeclaration(FileScopedNamespaceDeclarationSyntax node)
        {
            base.VisitFileScopedNamespaceDeclaration(node);
        }

        public override void VisitFinallyClause(FinallyClauseSyntax node)
        {
            base.VisitFinallyClause(node);
        }

        public override void VisitFixedStatement(FixedStatementSyntax node)
        {
            base.VisitFixedStatement(node);
        }

        public override void VisitForEachStatement(ForEachStatementSyntax node)
        {
            string fullStatement =
                $"{node.ForEachKeyword} ({node.Type.GetText()}{node.Identifier.Text} {node.InKeyword.Text} {node.Expression})";
            Console.WriteLine(fullStatement);
            this._walkerLog.StartLoop(fullStatement);

            var test = node.ForEachKeyword.ValueText + " " + node.InKeyword.ValueText.ToString() + " " +
                       node.Expression.GetText().ToString();

            fullStatement = $"foreach ({node.Expression.GetText()})";
            base.VisitForEachStatement(node);
            this._walkerLog.EndLoop();
        }

        public override void VisitForEachVariableStatement(ForEachVariableStatementSyntax node)
        {
            base.VisitForEachVariableStatement(node);
        }

        public override void VisitForStatement(ForStatementSyntax node)
        {
            string fullStatement = $"for ({node.Declaration}; {node.Condition}; {node.Incrementors})";
            Console.WriteLine($"For statement: {fullStatement}");
            this._walkerLog.StartLoop($"{fullStatement}");
            base.VisitForStatement(node);
            this._walkerLog.EndLoop();
        }

        public override void VisitFromClause(FromClauseSyntax node)
        {
            base.VisitFromClause(node);
        }

        public override void VisitFunctionPointerCallingConvention(FunctionPointerCallingConventionSyntax node)
        {
            base.VisitFunctionPointerCallingConvention(node);
        }

        public override void VisitFunctionPointerParameter(FunctionPointerParameterSyntax node)
        {
            base.VisitFunctionPointerParameter(node);
        }

        public override void VisitFunctionPointerParameterList(FunctionPointerParameterListSyntax node)
        {
            base.VisitFunctionPointerParameterList(node);
        }

        public override void VisitFunctionPointerType(FunctionPointerTypeSyntax node)
        {
            base.VisitFunctionPointerType(node);
        }

        public override void VisitFunctionPointerUnmanagedCallingConvention(
            FunctionPointerUnmanagedCallingConventionSyntax node)
        {
            base.VisitFunctionPointerUnmanagedCallingConvention(node);
        }

        public override void VisitFunctionPointerUnmanagedCallingConventionList(
            FunctionPointerUnmanagedCallingConventionListSyntax node)
        {
            base.VisitFunctionPointerUnmanagedCallingConventionList(node);
        }

        public override void VisitGenericName(GenericNameSyntax node)
        {
            base.VisitGenericName(node);
        }

        public override void VisitGlobalStatement(GlobalStatementSyntax node)
        {
            base.VisitGlobalStatement(node);
        }

        public override void VisitGotoStatement(GotoStatementSyntax node)
        {
            base.VisitGotoStatement(node);
        }

        public override void VisitGroupClause(GroupClauseSyntax node)
        {
            base.VisitGroupClause(node);
        }

        public override void VisitIdentifierName(IdentifierNameSyntax node)
        {
            base.VisitIdentifierName(node);
        }

        public override void VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
        {
            base.VisitIfDirectiveTrivia(node);
        }

        public override void VisitIfStatement(IfStatementSyntax node)
        {
            string ifStatement = node.Condition.GetText().ToString();
            Console.WriteLine($"If statement: {ifStatement}");
            LivingDocumentation.Uml.StringBuilderExtensions.GroupStart(this._walkerLog, "if", ifStatement);
            base.VisitIfStatement(node);
            LivingDocumentation.Uml.StringBuilderExtensions.GroupEnd(this._walkerLog);
        }

        public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
        {
            base.VisitImplicitArrayCreationExpression(node);
        }

        public override void VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
        {
            base.VisitImplicitElementAccess(node);
        }

        public override void VisitImplicitObjectCreationExpression(ImplicitObjectCreationExpressionSyntax node)
        {
            base.VisitImplicitObjectCreationExpression(node);
        }

        public override void VisitImplicitStackAllocArrayCreationExpression(
            ImplicitStackAllocArrayCreationExpressionSyntax node)
        {
            base.VisitImplicitStackAllocArrayCreationExpression(node);
        }

        public override void VisitIncompleteMember(IncompleteMemberSyntax node)
        {
            base.VisitIncompleteMember(node);
        }

        public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
        {
            base.VisitIndexerDeclaration(node);
        }

        public override void VisitIndexerMemberCref(IndexerMemberCrefSyntax node)
        {
            base.VisitIndexerMemberCref(node);
        }

        public override void VisitInitializerExpression(InitializerExpressionSyntax node)
        {
            base.VisitInitializerExpression(node);
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            base.VisitInterfaceDeclaration(node);
        }

        public override void VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
        {
            base.VisitInterpolatedStringExpression(node);
        }

        public override void VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
        {
            base.VisitInterpolatedStringText(node);
        }

        public override void VisitInterpolation(InterpolationSyntax node)
        {
            base.VisitInterpolation(node);
        }

        public override void VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)
        {
            base.VisitInterpolationAlignmentClause(node);
        }

        public override void VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)
        {
            base.VisitInterpolationFormatClause(node);
        }

        public override void VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            string calledMethod = string.Empty;
            ;
            string calledMethodClass = string.Empty;
            ;
            string callerName = string.Empty;
            string calledName = string.Empty;
            string description = string.Empty;
            string localVariableDeclaration = String.Empty;
            ITypeSymbol returnStatement = null;

            var callerMethod = node.InWhichMethod();
            var callerMethodClass = node.InWhichTypeDeclaration();
            callerName = callerMethod.Identifier.ValueText;

            var callerMethodSymbol = this.Model
                .GetSymbolInfo(callerMethod)
                .Symbol as IMethodSymbol;
            var calledMethodSymbol = this.Model
                .GetSymbolInfo(node)
                .Symbol as IMethodSymbol;

            if (calledMethodSymbol != null)
            {
                calledMethod = calledMethodSymbol.Name;
                calledMethodClass = calledMethodSymbol.ContainingType.Name;
                returnStatement = calledMethodSymbol.ReturnType;
            }

            callerName = callerMethod.Identifier.ValueText;
            calledName = calledMethod;


            bool callingMethodSameCLassAsCalledMethod = calledMethodClass == callerMethodClass.Identifier.ValueText;


            var memberAccess = node.Expression as MemberAccessExpressionSyntax;
            if (memberAccess != null)
            {
                if (memberAccess.Expression is IdentifierNameSyntax)
                {
                    IdentifierNameSyntax member = (IdentifierNameSyntax)memberAccess.Expression;
                    var m2 = member.Identifier;
                    var memberSymbolInfo = this.Model.GetSymbolInfo(member);
                    var memberSymbol = memberSymbolInfo.Symbol;

                    var memberLocations = memberSymbol.Locations;

                    foreach (var location in memberLocations)
                    {
                        var queryNode = location.SourceTree?.GetRoot()?.FindNode(location.SourceSpan);
                        localVariableDeclaration =
                            $"{((VariableDeclarationSyntax)queryNode.Parent).Type.ToString()} {queryNode.GetText().ToString()}";
                        string message2 =
                            $"Variable instantiation: {((VariableDeclarationSyntax)queryNode.Parent).Type.ToString()} {queryNode.GetText().ToString()}";

                        Console.WriteLine(message2);
                        this._walkerLog.Create(localVariableDeclaration);
                        Console.WriteLine(queryNode.ToString());
                    }
                    // The target is a simple identifier, the code being analysed is of the form
                    // "command.ExecuteReader()" and memberAccess.Expression is the "command"
                    // node
                }
                else if (memberAccess.Expression is MemberAccessExpressionSyntax)
                {
                    var member = (MemberAccessExpressionSyntax)memberAccess.Expression;
                    var memberSymbolInfo = this.Model.GetSymbolInfo(member);
                    var memberSymbol = memberSymbolInfo.Symbol;

                    var memberLocations = memberSymbol.Locations;

                    foreach (var location in memberLocations)
                    {
                        var queryNode = location.SourceTree?.GetRoot()?.FindNode(location.SourceSpan);
                    }
                    // The target is a member access, the code being analysed is of the form
                    // "x.Command.ExecuteReader()" and memberAccess.Expression is the "x.Command"
                    // node
                }
            }

            if (!callingMethodSameCLassAsCalledMethod && calledMethodSymbol != null)
            {
                string invocationDetails =
                    $"{calledMethodSymbol.ToFullyQualifiedName()}({string.Join(",", calledMethodSymbol?.Parameters.Select(s => s?.ToDisplayString()))})";

                this._walkerLog.CreateActor(callerName, callerName);
                this._walkerLog.CreateActor(calledName, calledName);
                this._walkerLog.Actor(callerName, callerName);
                this._walkerLog.Participant(calledMethod, calledMethod, ParticipantType.Actor);
                this._walkerLog.Arrow(callerName,
                    calledMethodClass,
                    invocationDetails.Replace(Environment.NewLine, "\\n"));
            }
            else if (callingMethodSameCLassAsCalledMethod &&
                     calledMethodSymbol != null) // (callingMethodSameCLassAsCalledMethod)
            {
                string invocationDetails =
                    $"{calledMethodSymbol.ToFullyQualifiedName()}({string.Join(",", calledMethodSymbol?.Parameters.Select(s => s?.ToDisplayString()))})";

                this._walkerLog.CreateActor(callerName, callerName);
                this._walkerLog.CreateActor(calledName, calledName);
                this._walkerLog.Actor(callerName, callerName);
                this._walkerLog.Participant(calledMethod, calledMethod, ParticipantType.Actor);
                this._walkerLog.Arrow(callerName,
                    calledMethodClass,
                    invocationDetails.Replace(Environment.NewLine, "\\n"));
            }

            Console.WriteLine($"Above was declared via: {localVariableDeclaration}");
            base.VisitInvocationExpression(node);
            if (returnStatement != null)
            {
                this._walkerLog.Return(returnStatement?.ToDisplayString());
            }
            else
            {
                this._walkerLog.Return();
            }
        }

        public override void VisitIsPatternExpression(IsPatternExpressionSyntax node)
        {
            base.VisitIsPatternExpression(node);
        }

        public override void VisitJoinClause(JoinClauseSyntax node)
        {
            base.VisitJoinClause(node);
        }

        public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
        {
            base.VisitJoinIntoClause(node);
        }

        public override void VisitLabeledStatement(LabeledStatementSyntax node)
        {
            base.VisitLabeledStatement(node);
        }

        public override void VisitLeadingTrivia(SyntaxToken token)
        {
            base.VisitLeadingTrivia(token);
        }

        public override void VisitLetClause(LetClauseSyntax node)
        {
            base.VisitLetClause(node);
        }

        public override void VisitLineDirectivePosition(LineDirectivePositionSyntax node)
        {
            base.VisitLineDirectivePosition(node);
        }

        public override void VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)
        {
            base.VisitLineDirectiveTrivia(node);
        }

        public override void VisitLineSpanDirectiveTrivia(LineSpanDirectiveTriviaSyntax node)
        {
            base.VisitLineSpanDirectiveTrivia(node);
        }

        public override void VisitListPattern(ListPatternSyntax node)
        {
            base.VisitListPattern(node);
        }

        public override void VisitLiteralExpression(LiteralExpressionSyntax node)
        {
            base.VisitLiteralExpression(node);
        }

        public override void VisitLoadDirectiveTrivia(LoadDirectiveTriviaSyntax node)
        {
            base.VisitLoadDirectiveTrivia(node);
        }

        public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        {
            base.VisitLocalDeclarationStatement(node);
        }

        public override void VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
        {
            base.VisitLocalFunctionStatement(node);
        }

        public override void VisitLockStatement(LockStatementSyntax node)
        {
            base.VisitLockStatement(node);
        }

        public override void VisitMakeRefExpression(MakeRefExpressionSyntax node)
        {
            base.VisitMakeRefExpression(node);
        }

        public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            base.VisitMemberAccessExpression(node);
        }

        public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
        {
            base.VisitMemberBindingExpression(node);
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            // Console.WriteLine($"Method Declaration: {node.Identifier.Text}");
            // this._walkerLog.AppendLine($"Method declaration: {node.Identifier.Text}");
            // var symbol = this.Model.GetDeclaredSymbol(node) as IMethodSymbol;
            base.VisitMethodDeclaration(node);
        }

        public override void VisitNameColon(NameColonSyntax node)
        {
            base.VisitNameColon(node);
        }

        public override void VisitNameEquals(NameEqualsSyntax node)
        {
            base.VisitNameEquals(node);
        }

        public override void VisitNameMemberCref(NameMemberCrefSyntax node)
        {
            base.VisitNameMemberCref(node);
        }

        public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            base.VisitNamespaceDeclaration(node);
        }

        public override void VisitNullableDirectiveTrivia(NullableDirectiveTriviaSyntax node)
        {
            base.VisitNullableDirectiveTrivia(node);
        }

        public override void VisitNullableType(NullableTypeSyntax node)
        {
            base.VisitNullableType(node);
        }

        public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            base.VisitObjectCreationExpression(node);
        }

        public override void VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
        {
            base.VisitOmittedArraySizeExpression(node);
        }

        public override void VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
        {
            base.VisitOmittedTypeArgument(node);
        }

        public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
        {
            base.VisitOperatorDeclaration(node);
        }

        public override void VisitOperatorMemberCref(OperatorMemberCrefSyntax node)
        {
            base.VisitOperatorMemberCref(node);
        }

        public override void VisitOrderByClause(OrderByClauseSyntax node)
        {
            base.VisitOrderByClause(node);
        }

        public override void VisitOrdering(OrderingSyntax node)
        {
            base.VisitOrdering(node);
        }

        public override void VisitParameter(ParameterSyntax node)
        {
            base.VisitParameter(node);
        }

        public override void VisitParameterList(ParameterListSyntax node)
        {
            base.VisitParameterList(node);
        }

        public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            base.VisitParenthesizedExpression(node);
        }

        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            base.VisitParenthesizedLambdaExpression(node);
        }

        public override void VisitParenthesizedPattern(ParenthesizedPatternSyntax node)
        {
            base.VisitParenthesizedPattern(node);
        }

        public override void VisitParenthesizedVariableDesignation(ParenthesizedVariableDesignationSyntax node)
        {
            base.VisitParenthesizedVariableDesignation(node);
        }

        public override void VisitPointerType(PointerTypeSyntax node)
        {
            base.VisitPointerType(node);
        }

        public override void VisitPositionalPatternClause(PositionalPatternClauseSyntax node)
        {
            base.VisitPositionalPatternClause(node);
        }

        public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            base.VisitPostfixUnaryExpression(node);
        }

        public override void VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)
        {
            base.VisitPragmaChecksumDirectiveTrivia(node);
        }

        public override void VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)
        {
            base.VisitPragmaWarningDirectiveTrivia(node);
        }

        public override void VisitPredefinedType(PredefinedTypeSyntax node)
        {
            base.VisitPredefinedType(node);
        }

        public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            base.VisitPrefixUnaryExpression(node);
        }

        public override void VisitPrimaryConstructorBaseType(PrimaryConstructorBaseTypeSyntax node)
        {
            base.VisitPrimaryConstructorBaseType(node);
        }

        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            base.VisitPropertyDeclaration(node);
        }

        public override void VisitPropertyPatternClause(PropertyPatternClauseSyntax node)
        {
            base.VisitPropertyPatternClause(node);
        }

        public override void VisitQualifiedCref(QualifiedCrefSyntax node)
        {
            base.VisitQualifiedCref(node);
        }

        public override void VisitQualifiedName(QualifiedNameSyntax node)
        {
            base.VisitQualifiedName(node);
        }

        public override void VisitQueryBody(QueryBodySyntax node)
        {
            base.VisitQueryBody(node);
        }

        public override void VisitQueryContinuation(QueryContinuationSyntax node)
        {
            base.VisitQueryContinuation(node);
        }

        public override void VisitQueryExpression(QueryExpressionSyntax node)
        {
            base.VisitQueryExpression(node);
        }

        public override void VisitRangeExpression(RangeExpressionSyntax node)
        {
            base.VisitRangeExpression(node);
        }

        public override void VisitRecordDeclaration(RecordDeclarationSyntax node)
        {
            base.VisitRecordDeclaration(node);
        }

        public override void VisitRecursivePattern(RecursivePatternSyntax node)
        {
            base.VisitRecursivePattern(node);
        }

        public override void VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)
        {
            base.VisitReferenceDirectiveTrivia(node);
        }

        public override void VisitRefExpression(RefExpressionSyntax node)
        {
            base.VisitRefExpression(node);
        }

        public override void VisitRefType(RefTypeSyntax node)
        {
            base.VisitRefType(node);
        }

        public override void VisitRefTypeExpression(RefTypeExpressionSyntax node)
        {
            base.VisitRefTypeExpression(node);
        }

        public override void VisitRefValueExpression(RefValueExpressionSyntax node)
        {
            base.VisitRefValueExpression(node);
        }

        public override void VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
        {
            base.VisitRegionDirectiveTrivia(node);
        }

        public override void VisitRelationalPattern(RelationalPatternSyntax node)
        {
            base.VisitRelationalPattern(node);
        }

        public override void VisitReturnStatement(ReturnStatementSyntax node)
        {
            base.VisitReturnStatement(node);
        }

        public override void VisitSelectClause(SelectClauseSyntax node)
        {
            base.VisitSelectClause(node);
        }

        public override void VisitShebangDirectiveTrivia(ShebangDirectiveTriviaSyntax node)
        {
            base.VisitShebangDirectiveTrivia(node);
        }

        public override void VisitSimpleBaseType(SimpleBaseTypeSyntax node)
        {
            base.VisitSimpleBaseType(node);
        }

        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            base.VisitSimpleLambdaExpression(node);
        }

        public override void VisitSingleVariableDesignation(SingleVariableDesignationSyntax node)
        {
            base.VisitSingleVariableDesignation(node);
        }

        public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
        {
            base.VisitSizeOfExpression(node);
        }

        public override void VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
        {
            base.VisitSkippedTokensTrivia(node);
        }

        public override void VisitSlicePattern(SlicePatternSyntax node)
        {
            base.VisitSlicePattern(node);
        }

        public override void VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
        {
            base.VisitStackAllocArrayCreationExpression(node);
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            base.VisitStructDeclaration(node);
        }

        public override void VisitSubpattern(SubpatternSyntax node)
        {
            base.VisitSubpattern(node);
        }

        public override void VisitSwitchExpression(SwitchExpressionSyntax node)
        {
            base.VisitSwitchExpression(node);
        }

        public override void VisitSwitchExpressionArm(SwitchExpressionArmSyntax node)
        {
            base.VisitSwitchExpressionArm(node);
        }

        public override void VisitSwitchSection(SwitchSectionSyntax node)
        {
            base.VisitSwitchSection(node);
        }

        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        {
            base.VisitSwitchStatement(node);
        }

        public override void VisitThisExpression(ThisExpressionSyntax node)
        {
            base.VisitThisExpression(node);
        }

        public override void VisitThrowExpression(ThrowExpressionSyntax node)
        {
            base.VisitThrowExpression(node);
        }

        public override void VisitThrowStatement(ThrowStatementSyntax node)
        {
            base.VisitThrowStatement(node);
        }

        public override void VisitToken(SyntaxToken token)
        {
            base.VisitToken(token);
        }

        public override void VisitTrailingTrivia(SyntaxToken token)
        {
            base.VisitTrailingTrivia(token);
        }

        public override void VisitTrivia(SyntaxTrivia trivia)
        {
            base.VisitTrivia(trivia);
        }

        public override void VisitTryStatement(TryStatementSyntax node)
        {
            base.VisitTryStatement(node);
        }

        public override void VisitTupleElement(TupleElementSyntax node)
        {
            base.VisitTupleElement(node);
        }

        public override void VisitTupleExpression(TupleExpressionSyntax node)
        {
            base.VisitTupleExpression(node);
        }

        public override void VisitTupleType(TupleTypeSyntax node)
        {
            base.VisitTupleType(node);
        }

        public override void VisitTypeArgumentList(TypeArgumentListSyntax node)
        {
            base.VisitTypeArgumentList(node);
        }

        public override void VisitTypeConstraint(TypeConstraintSyntax node)
        {
            base.VisitTypeConstraint(node);
        }

        public override void VisitTypeCref(TypeCrefSyntax node)
        {
            base.VisitTypeCref(node);
        }

        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            base.VisitTypeOfExpression(node);
        }

        public override void VisitTypeParameter(TypeParameterSyntax node)
        {
            base.VisitTypeParameter(node);
        }

        public override void VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
        {
            base.VisitTypeParameterConstraintClause(node);
        }

        public override void VisitTypeParameterList(TypeParameterListSyntax node)
        {
            base.VisitTypeParameterList(node);
        }

        public override void VisitTypePattern(TypePatternSyntax node)
        {
            base.VisitTypePattern(node);
        }

        public override void VisitUnaryPattern(UnaryPatternSyntax node)
        {
            base.VisitUnaryPattern(node);
        }

        public override void VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)
        {
            base.VisitUndefDirectiveTrivia(node);
        }

        public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            base.VisitUnsafeStatement(node);
        }

        public override void VisitUsingDirective(UsingDirectiveSyntax node)
        {
            base.VisitUsingDirective(node);
        }

        public override void VisitUsingStatement(UsingStatementSyntax node)
        {
            base.VisitUsingStatement(node);
        }

        public override void VisitVariableDeclaration(VariableDeclarationSyntax node)
        {
            base.VisitVariableDeclaration(node);
        }

        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            base.VisitVariableDeclarator(node);
        }

        public override void VisitVarPattern(VarPatternSyntax node)
        {
            base.VisitVarPattern(node);
        }

        public override void VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)
        {
            base.VisitWarningDirectiveTrivia(node);
        }

        public override void VisitWhenClause(WhenClauseSyntax node)
        {
            base.VisitWhenClause(node);
        }

        public override void VisitWhereClause(WhereClauseSyntax node)
        {
            base.VisitWhereClause(node);
        }

        public override void VisitWhileStatement(WhileStatementSyntax node)
        {
            base.VisitWhileStatement(node);
        }

        public override void VisitWithExpression(WithExpressionSyntax node)
        {
            base.VisitWithExpression(node);
        }

        public override void VisitXmlCDataSection(XmlCDataSectionSyntax node)
        {
            base.VisitXmlCDataSection(node);
        }

        public override void VisitXmlComment(XmlCommentSyntax node)
        {
            base.VisitXmlComment(node);
        }

        public override void VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
        {
            base.VisitXmlCrefAttribute(node);
        }

        public override void VisitXmlElement(XmlElementSyntax node)
        {
            base.VisitXmlElement(node);
        }

        public override void VisitXmlElementEndTag(XmlElementEndTagSyntax node)
        {
            base.VisitXmlElementEndTag(node);
        }

        public override void VisitXmlElementStartTag(XmlElementStartTagSyntax node)
        {
            base.VisitXmlElementStartTag(node);
        }

        public override void VisitXmlEmptyElement(XmlEmptyElementSyntax node)
        {
            base.VisitXmlEmptyElement(node);
        }

        public override void VisitXmlName(XmlNameSyntax node)
        {
            base.VisitXmlName(node);
        }

        public override void VisitXmlNameAttribute(XmlNameAttributeSyntax node)
        {
            base.VisitXmlNameAttribute(node);
        }

        public override void VisitXmlPrefix(XmlPrefixSyntax node)
        {
            base.VisitXmlPrefix(node);
        }

        public override void VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
        {
            base.VisitXmlProcessingInstruction(node);
        }

        public override void VisitXmlText(XmlTextSyntax node)
        {
            base.VisitXmlText(node);
        }

        public override void VisitXmlTextAttribute(XmlTextAttributeSyntax node)
        {
            base.VisitXmlTextAttribute(node);
        }

        public override void VisitYieldStatement(YieldStatementSyntax node)
        {
            base.VisitYieldStatement(node);
        }

        public string GetFinishedDiagram()
        {
            return this._walkerLog.ToString();
        }
    }
}