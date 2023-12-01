describe('template spec', () => {
  it('can leverage configuration', () => {
    cy.visit('http://localhost:5156/')
    cy.get("#ConfigValue").should('contain.text', 'Configuration valid')
  })

  it('can show pictures', () => {
    cy.visit('http://localhost:5156/pics/pizza')
    cy.get('[id="pic"]', { timeout: 500 }).should('have.length', 8)
  })

  it('about should show picture', () => {
    cy.visit('http://localhost:5156/')
    cy.get('.top-row > a').click();
    cy.get('#logo').should('have.attr', 'src', '_content/PictureApp.Shared/images/fullstack-logo.png')
  })

  /* ==== Test Created with Cypress Studio ==== */
  it('Click through', function() {
    /* ==== Generated with Cypress Studio ==== */
    cy.visit('http://localhost:5156/pics/beach');
    cy.get('[d="M16.59 8.59L12 13.17 7.41 8.59 6 10l6 6 6-6z"]').click();
    cy.get('.mud-expand-panel-content > .mud-typography').click();
    cy.get('.mud-expand-panel-content > .mud-typography').click();
    cy.get('.mud-expand-panel-content > .mud-typography').click();
    cy.get(':nth-child(4) > .mud-paper > .mud-card-actions > a.mud-button-root > .mud-button-label').click();
    /* ==== End Cypress Studio ==== */
  });
})

