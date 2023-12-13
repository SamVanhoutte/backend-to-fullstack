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
  it('Counter test', function() {
    /* ==== Generated with Cypress Studio ==== */
    cy.visit('http://localhost:5156/counter');
    cy.get('#reset > .mud-button-label').click();// Increase
    cy.wait(50);
    cy.get('#increase > .mud-button-label').click();// Increase
    cy.wait(50);
    cy.get('#increase > .mud-button-label').click();// Increase
    cy.wait(50);
    cy.get('#increase > .mud-button-label').click();// Increase
    cy.wait(50);
    cy.get('#decrease > .mud-button-label').click();// Decrease
    cy.get('#counter').should('have.text', 'Current count: 2');

    /* ==== End Cypress Studio ==== */
  });

  /* ==== Test Created with Cypress Studio ==== */
  it('Clodubrew', function() {
    /* ==== Generated with Cypress Studio ==== */
    cy.visit('http://localhost:5156/counter');
    cy.get('#reset > .mud-button-label').click();
    cy.get('#decrease > .mud-button-label').click();
    cy.get('#increase > .mud-button-label').click();
    cy.get('#increase > .mud-button-label').click();
    cy.get('#increase > .mud-button-label').click();
    cy.get('#decrease > .mud-button-label').click();
    cy.get('#increase').click();
    cy.get('.mud-grid > :nth-child(4)').click();
    /* ==== End Cypress Studio ==== */
  });
})

